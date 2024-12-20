using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
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

namespace Tarea_Final
{
    public partial class frmConsultAppointment : Form
    {
        private User user { get; set; }
        private Appointment appointment { get; set; }
        private Service service { get; set; }
        private Employee employee { get; set; }

        public frmConsultAppointment(User user)
        {
            InitializeComponent();
            LoadCmbServicios();
            LoadCmbEmpleados();
            this.user = user;
            this.Load += new EventHandler(ConsultarCita_Load);
        }

        private async void LoadCmbServicios()
        {
            string query = "SELECT Name FROM Services";

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
            string query = @"SELECT u.Name FROM Employees e JOIN Users u ON e.UserId = u.UserId";

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

        private async void ConsultarCita_Load(object? sender, EventArgs e)
        {
            await LoadAppointmentsDataGridView();
        }

        internal async Task LoadAppointmentsDataGridView()
        {
            try
            {
                List<Appointment> appointments = await Appointment.GetAppointmentsByUser(user);

                if (appointments == null || !appointments.Any())
                {
                    MessageBox.Show("No se encontraron citas para el usuario.");
                    return;
                }

                appointments = appointments.OrderBy(a => a.Date).ToList();

                dgvCitas.Rows.Clear();

                foreach (Appointment appointment in appointments)
                {
                    if(appointment.Status == "Cancelada") 
                        continue;

                    Employee employee = await Employee.GetEmployee(appointment.IdEmployee);
                    dgvCitas.Rows.Add(appointment.IdAppointment, appointment.Service.Name, appointment.Service.Price, appointment.Date, appointment.Hour, employee.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar las citas: {ex.Message}");
            }
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

                    cmbServicios.Text = "";
                    txtDescripcion.Text = "";
                    lblPrecio.Text = "Price";
                    cmbEmpleados.Text = "";
                    dtpFecha.Value = DateTime.Today;
                    dtpHora.Value = DateTime.Today;
                    cmbStatus.Text = "";    

                    await Appointment.ModifyAppointment(appointment);
                    await LoadAppointmentsDataGridView();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void dgvCitas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    int idCita = int.Parse(dgvCitas.Rows[e.RowIndex].Cells[0].Value.ToString());
                    this.appointment = await Appointment.GetAppointment(idCita);

                    cmbServicios.Text = appointment.Service.Name;
                    txtDescripcion.Text = appointment.Service.Description;
                    lblPrecio.Text = appointment.Service.Price.ToString();
                    Employee employee = await Employee.GetEmployee(appointment.IdEmployee);
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

        private async void cmbServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadServiceDetails(cmbServicios.Text);
        }

        private async Task LoadServiceDetails(string serviceName)
        {
            string query = "SELECT ServiceId, Price, Description FROM Services WHERE Name = @Name";

            try
            {
                using (SqlConnection connection = Connection.Connect())
                {
                    await connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", serviceName);
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                int serviceId = (int)reader["ServiceId"];
                                this.service = await Service.GetServiceById(serviceId);
                                lblPrecio.Text = reader["Price"].ToString() + "$";
                                txtDescripcion.Text = reader["Description"].ToString();
                            }
                            else
                            {
                                lblPrecio.Text = "No se encontraron datos";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar detalles del servicio: {ex.Message}");
            }
        }

        private async void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = @"SELECT e.UserId 
                             FROM Employees e 
                             JOIN Users u ON e.UserId = u.UserId 
                             WHERE u.Name = @Name";

            try
            {
                using (SqlConnection connection = Connection.Connect())
                {
                    await connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", cmbEmpleados.Text);
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                this.employee = await Employee.GetEmployee((int)reader["UserId"]);
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el empleado seleccionado.");
                            }
                        }
                    }
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
