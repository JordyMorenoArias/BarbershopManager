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

namespace Tarea_Final.Forms.Admin
{
    public partial class frmNewAppointmentAdmin : Form
    {
        private Models.User user { get; set; }
        private Employee employee { get; set; } = null!;
        private Service service { get; set; }

        public frmNewAppointmentAdmin(Models.User user)
        {
            InitializeComponent();

            this.user = user;
            LoadCmbServicios();
            LoadCmbEmpleados();
            LoadCmbUsersIdCard();
            PerfilLoad();
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
            string query = @"SELECT u.Name FROM Employees e JOIN Users u ON e.UserId = u.UserId WHERE e.Position = 'Barbero/a' AND e.Status = 1";

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

        private void PerfilLoad()
        {
            cmbCedula.Text = user.IdCard;
            lblName.Text = user.Name;
            lblEmail.Text = user.Email;
            lblPhoneNumber.Text = user.PhoneNumber;
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se haya seleccionado un servicio y un empleado
                if (service == null || service.IdService == 0)
                {
                    MessageBox.Show("Por favor, seleccione un servicio.");
                    return;
                }
                if (service.IdService == 0)
                {
                    MessageBox.Show("Por favor, seleccione un servicio.");
                    return;
                }

                if (employee == null || employee.IdEmployee == 0)
                {
                    MessageBox.Show("Por favor, seleccione un empleado.");
                    return;
                }
                if (employee.IdEmployee == 0 || employee == null)
                {
                    MessageBox.Show("Por favor, seleccione un empleado.");
                    return;
                }

                // Validar que se haya seleccionado una fecha y hora válidas
                if (dtpFecha.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("La fecha seleccionada no puede ser anterior a la fecha actual.");
                    return;
                }

                if (dtpHora.Value.TimeOfDay < DateTime.Now.TimeOfDay && dtpFecha.Value.Date == DateTime.Now.Date)
                {
                    MessageBox.Show("La hora seleccionada no puede ser anterior a la hora actual.");
                    return;
                }

                if (await CheckEmployeeAvailability(employee.IdEmployee, dtpFecha.Value.Date, dtpHora.Value.TimeOfDay))
                {
                    User user = await User.GetUserByIdCard(cmbCedula.Text);
                    Appointment appointment = new Appointment
                    (
                        employee,
                        user,
                        dtpFecha.Value.Date,
                        dtpHora.Value.TimeOfDay,
                        service,
                        "Pendiente"
                    );

                    await Appointment.CreateAppointment(appointment);
                    MessageBox.Show($"La cita del usuario {user.Name} fue creada exitosamente.");

                    this.Owner?.Close();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error de base de datos al crear la cita: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la cita: {ex.Message}");
            }
        }
        internal async Task<bool> CheckEmployeeAvailability(int employeeId, DateTime date, TimeSpan hour)
        {
            Employee employee = await Employee.GetEmployeeById(employeeId);

            var busySchedules = await Schedule.GetSchedulesbyEmployee(employee.IdEmployee);

            foreach (var schedule in busySchedules)
            {
                if (schedule.Date.Date == date.Date && schedule.StartHour <= hour && schedule.FinalHour >= hour)
                {
                    MessageBox.Show($"{employee.Name} ya tiene una cita programada a esa hora. Estará disponible a partir de las {DateTime.Today.Add(schedule.FinalHour).ToString("hh:mm tt")}.");
                    return false;
                }
            }
            return true;
        }

        private async void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = @"SELECT e.EmployeeId 
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
                                this.employee = await Employee.GetEmployeeById((int)reader["EmployeeId"]);
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

        private async void cmbServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT ServiceId, Price, Description FROM Services WHERE Name = @Name";

            try
            {
                using (SqlConnection connection = Connection.Connect())
                {
                    await connection.OpenAsync(); // Asegúrate de que la conexión esté completamente abierta
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", cmbServicios.Text);
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

        private async void cmbCedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = Connection.Connect())
            {
                string query = "SELECT Name, Email, PhoneNumber FROM Users WHERE IdCard = @IdCard";

                try
                {
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdCard", cmbCedula.Text);

                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                lblName.Text = reader["Name"].ToString();
                                lblEmail.Text = reader["Email"].ToString();
                                lblPhoneNumber.Text = reader["PhoneNumber"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar detalles del Usuario Seleccionado {ex.Message}");
                }

            }
        }
    }
}
