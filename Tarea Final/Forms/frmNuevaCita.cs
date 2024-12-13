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

namespace Tarea_Final
{
    public partial class frmNuevaCita : Form
    {
        private int idEmployee { get; set; }
        private int idUser { get; set; }
        private int idService { get; set; }

        public frmNuevaCita(User user)
        {
            InitializeComponent();

            LoadCmbServicios();
            LoadCmbEmpleados();
            this.idUser = user.Id;
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

        private void NuevaCita_Load(object sender, EventArgs e)
        {
            // Código para manejar el evento de carga del formulario
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Código para manejar el evento de clic en el botón Buscar
        }

        internal async Task<bool> CheckEmployeeAvailability(int employeeId, DateTime date, TimeSpan hour)
        {
            Employee employee = Employee.GetEmployee(employeeId);

            var busySchedules = await Schedule.GetSchedulesbyEmployee(int.Parse(employee.IdEmployee));

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

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se haya seleccionado un servicio y un empleado
                if (idService == 0)
                {
                    MessageBox.Show("Por favor, seleccione un servicio.");
                    return;
                }

                if (idEmployee == 0)
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

                if (await CheckEmployeeAvailability(idEmployee, dtpFecha.Value.Date, dtpHora.Value.TimeOfDay))
                {
                    Service service = await Service.GetServiceById(idService);
                    Appointment appointment = new Appointment
                    (
                        idEmployee,
                        idUser,
                        dtpFecha.Value.Date,
                        dtpHora.Value.TimeOfDay,
                        service,
                        "Pendiente"
                    );

                    await Appointment.CreateAppointment(appointment);
                    MessageBox.Show("Cita creada exitosamente.");
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void cmbServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT ServiceId, Price, Description FROM Services WHERE Name = @Name";

            try
            {
                using (SqlConnection connection = Connection.Connect())
                {
                    await connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", cmbServicios.Text);
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                this.idService = (int)reader["ServiceId"];
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

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = @"SELECT e.UserId 
                             FROM Employees e 
                             JOIN Users u ON e.UserId = u.UserId 
                             WHERE u.Name = @Name";

            try
            {
                using (SqlConnection connection = Connection.Connect())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", cmbEmpleados.Text);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                this.idEmployee = (int)reader["UserId"];
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

        private void dtpHora_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
