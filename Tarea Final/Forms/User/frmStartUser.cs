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
using User = Tarea_Final.Models.User;


namespace Tarea_Final.Forms
{
    public partial class frmStartUser : Form
    {
        private User user { get; set; }
        public frmStartUser(User user)
        {
            InitializeComponent();
            this.user = user;
            LoadUserUpcomingAppointments(user);
        }

        private async void LoadUserUpcomingAppointments(User user)
        {
            try
            {
                List<Appointment> appointments = await UserUpcomingAppointments(user);

                lblCitasHoy.Text = appointments.Count.ToString();
                foreach (var appointment in appointments)
                {
                    DateTime appointmentTime = DateTime.Today.Add(appointment.Hour);
                    string formattedHour = appointmentTime.ToString("hh:mm tt");
                    listBoxProximasCitas.Items.Add($"{appointment.Date.ToString("d")} - {formattedHour} - {appointment.Service.Name}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error al cargar las citas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<List<Appointment>> UserUpcomingAppointments(User user)
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

                    string query = @"SELECT a.Hour, a.Date, s.Name 
                                        FROM Appointments a 
                                        JOIN Services s ON a.ServiceId = s.ServiceId 
                                        WHERE a.UserId = @UserId 
                                        AND a.Date >= @CurrentDate
                                        AND a.Date <= DATEADD(day, 7, @CurrentDate)  
                                        AND a.status = 'Pendiente'
                                        ORDER BY a.Date, a.Hour;";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", user.UserId);
                        command.Parameters.AddWithValue("@CurrentDate", DateTime.Now.Date);
                        command.Parameters.AddWithValue("@CurrentTime", DateTime.Now.TimeOfDay);

                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                appointments.Add(new Appointment
                                {
                                    Hour = reader.GetTimeSpan(reader.GetOrdinal("Hour")),
                                    Date = reader.GetDateTime(reader.GetOrdinal("Date")),
                                    Service = new Service
                                    {
                                        Name = reader["Name"].ToString()!
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

        private void frmStartUser_Load(object sender, EventArgs e)
        {

        }
    }
}
