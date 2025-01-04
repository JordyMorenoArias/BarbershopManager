using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_Final.Models;

namespace Tarea_Final.Forms
{
    public partial class frmConsultAppointmentAdmin : Form
    {
        private User user { get; set; } = null!;
        private Appointment appointment { get; set; } = null!;
        private Employee employee { get; set; } = null!;

        public frmConsultAppointmentAdmin(User user)
        {
            InitializeComponent();
            this.user = user;
            LoadCmbServicios();
            LoadCmbEmpleados();
            LoadCmbUsersIdCard();
            this.Load += async (sender, e) => await LoadAppointmentsDataGridView();
        }

        private async Task LoadAppointmentsDataGridView()
        {
            try
            {

                List<Appointment> appointments = new List<Appointment>();

                if (cmbCedula.Text == "All")
                {
                    appointments = await Appointment.GetAppointments();
                }
                else
                {
                    appointments = await Appointment.GetAppointmentsByUser(user!);
                }

                dgvCitas.Rows.Clear();

                if (appointments == null || !appointments.Any())
                {
                    return;
                }

                appointments = appointments.OrderBy(a => a.Date).Where(a => a.Status == "Pendiente").ToList();

                foreach (Appointment appointment in appointments)
                {

                    dgvCitas.Rows.Add(appointment.IdAppointment,
                                    appointment.User.UserId,
                                    appointment.Service.Name,
                                    appointment.Service.Price,
                                    appointment.Date,
                                    appointment.Hour,
                                    appointment.Employee.Name
                                    );

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar las citas: {ex.Message}");
            }
        }

        private void LoadDataUser(User user)
        {
            if (user != null)
            {
                lblName.Text = user.Name;
                lblEmail.Text = user.Email;
                lblPhoneNumber.Text = user.PhoneNumber;
            }
        }

        private async void LoadCmbServicios()
        {

            try
            {
                using (SqlConnection connection = Connection.Connect())
                {
                    string query = "SELECT Name FROM Services";
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                cmbServicios.Items.Add(reader["Name"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar servicios: {ex.Message}");
            }
        }

        private async void LoadCmbEmpleados()
        {
            try
            {
                using (SqlConnection connection = Connection.Connect())
                {
                    string query = @"SELECT u.Name FROM Employees e JOIN Users u ON e.UserId = u.UserId WHERE e.Position = 'Barbero/a'";
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                cmbEmpleados.Items.Add(reader["Name"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar empleados: {ex.Message}");
            }
        }

        private async void LoadCmbUsersIdCard()
        {
            string query = "SELECT IdCard FROM Users";
            try
            {
                using (SqlConnection connection = Connection.Connect())
                {
                    await connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                cmbCedula.Items.Add(reader["IdCard"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}");
            }
        }

        internal async Task<bool> CheckEmployeeAvailability(Employee employee, Appointment appointment)
        {
            List<Schedule> busySchedules = await Schedule.GetSchedulesbyEmployee(employee.IdEmployee);
            busySchedules = busySchedules.Where(s => s.Appointment.IdAppointment != appointment.IdAppointment).ToList();

            foreach (var schedule in busySchedules)
            {
                if (schedule.Date.Date == appointment.Date &&
                    schedule.StartHour <= appointment.Hour &&
                    schedule.FinalHour > appointment.Hour)
                {
                    if (appointment.Employee.IdEmployee == employee.IdEmployee && appointment.User.UserId != schedule.Appointment.User.UserId)
                    {
                        MessageBox.Show($"{employee.Name} ya tiene una cita programada a esa hora. Estará disponible a partir de las {DateTime.Today.Add(schedule.FinalHour):hh:mm tt}.");
                        return false;
                    }
                    else if (schedule.Appointment.IdAppointment != appointment.IdAppointment)
                    {
                        MessageBox.Show($"Ya tienes una cita programada a esta hora.");
                        return false;
                    }
                }
            }

            return true;
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (appointment != null)
            {
                try
                {
                    appointment.Service = await Service.GetServiceByName(cmbServicios.Text);
                    appointment.Date = dtpFecha.Value;
                    appointment.Hour = dtpHora.Value.TimeOfDay;
                    appointment.Status = cmbStatus.Text == "Cancelar" ? "Cancelada" : cmbStatus.Text;

                    if (appointment.Status == "Cancelada")
                    {
                        MessageBox.Show("La cita fue cancelada exitosamente");
                    }
                    else
                    {
                        bool isEmployeeAvailable = await CheckEmployeeAvailability(employee, appointment);
                        if (!isEmployeeAvailable)
                        {
                            return;
                        }
                    }

                    CleanTextBox();
                    await Appointment.ModifyAppointment(appointment);
                    await LoadAppointmentsDataGridView();
                    MessageBox.Show("La cita fue modificada exitosamente");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al modificar la cita: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una cita para modificar");
            }
        }

        private void CleanTextBox()
        {
            cmbServicios.Text = "";
            txtDescripcion.Text = "";
            lblPrecio.Text = "Price";
            cmbEmpleados.Text = "";
            dtpFecha.Value = DateTime.Today;
            dtpHora.Value = DateTime.Today;
            cmbStatus.Text = "";
        }

        private async void cmbCedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            CleanTextBox();

            if (cmbServicios.Text != "All")
            {
                User selectedUser = await User.GetUserByIdCard(cmbCedula.Text);
                this.user = selectedUser;
                LoadDataUser(selectedUser);
            }

            await LoadAppointmentsDataGridView();
        }

        private async void dgvCitas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    int idCita = int.Parse(dgvCitas.Rows[e.RowIndex].Cells[0].Value.ToString()!);
                    this.appointment = await Appointment.GetAppointmentById(idCita);

                    cmbServicios.Text = appointment.Service.Name;
                    txtDescripcion.Text = appointment.Service.Description;
                    lblPrecio.Text = appointment.Service.Price.ToString();
                    Employee employee = await Employee.GetEmployeeById(appointment.Employee.IdEmployee);
                    cmbEmpleados.Text = employee.Name;
                    dtpFecha.Value = appointment.Date;
                    dtpHora.Value = DateTime.Today.Add(appointment.Hour);
                    cmbStatus.Text = appointment.Status;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al cargar los detalles de la cita: {ex.Message}");
                }
            }
        }

        private async void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var employee = await Employee.GetEmployeeByName(cmbEmpleados.Text);
                if (employee != null)
                {
                    this.employee = employee;
                }
                else
                {
                    MessageBox.Show("No se encontró el empleado seleccionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar detalles del empleado: {ex.Message}");
            }
        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
