using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmStartAdmin : Form
    {
        public frmStartAdmin()
        {
            InitializeComponent();
            LoadUserUpcomingAppointments();
        }

        private async void LoadUserUpcomingAppointments()
        {
            try
            {
                List<Appointment> appointments = await UpcomingAppointments();

                lblCitaSem.Text = appointments.Count(a => a.Date <= DateTime.Now.AddDays(7)).ToString();
                lblGanProxSem.Text = appointments.Where(a => a.Date <= DateTime.Now.AddDays(7)).Sum(a => a.Service.Price).ToString("C2");
                lblGanEsteMes.Text = appointments.Where(a => a.Date.Month == DateTime.Now.Month && a.Status == "Completado").Sum(a => a.Service.Price).ToString("C2");

                foreach (var appointment in appointments)
                {
                    DateTime appointmentTime = DateTime.Today.Add(appointment.Hour);
                    string formattedHour = appointmentTime.ToString("hh:mm tt");
                    listBoxProximasCitas.Items.Add($"{appointment.Date.ToString("d")} - {formattedHour} - {appointment.User.Name} - {appointment.Service.Name}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error al cargar las citas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<List<Appointment>> UpcomingAppointments()
        {
            List<Appointment> appointments = new List<Appointment>();

            try
            {
                using (SqlConnection connection = Connection.Connect())
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        await connection.OpenAsync();
                    }

                    string query = @"SELECT a.Hour, a.Date, a.Status, u.Name AS UserName, s.Name AS ServiceName, s.Price  
                                     FROM Appointments a 
                                     JOIN Services s ON a.ServiceId = s.ServiceId 
                                     JOIN Users u ON a.UserId = u.UserId
                                     WHERE a.status = 'Pendiente'
                                     AND a.Date >= @CurrentDate
                                     AND a.Date <= DATEADD(day, 60, @CurrentDate)
                                     ORDER BY a.Date, a.Hour;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CurrentDate", DateTime.Now.Date);

                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                appointments.Add(new Appointment
                                {
                                    Hour = reader.GetTimeSpan(reader.GetOrdinal("Hour")),
                                    Date = reader.GetDateTime(reader.GetOrdinal("Date")),
                                    Status = reader["Status"].ToString()!,
                                    User = new Models.User
                                    {
                                        Name = reader["UserName"].ToString()!
                                    },
                                    Service = new Service
                                    {
                                        Name = reader["ServiceName"].ToString()!,
                                        Price = reader.GetDecimal(reader.GetOrdinal("Price"))
                                    }
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving appointments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return appointments;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
