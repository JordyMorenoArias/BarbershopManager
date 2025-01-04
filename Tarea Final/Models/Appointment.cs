using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Final.Models
{
    internal class Appointment
    {
        internal int IdAppointment { get; set; }
        internal Employee Employee { get; set; }
        internal User User { get; set; }
        internal DateTime Date { get; set; }
        internal TimeSpan Hour { get; set; }
        internal Service Service { get; set; }
        internal string Status { get; set; }

        public Appointment() { }

        public Appointment(Employee employee, User user, DateTime date, TimeSpan hour, Service service, string status)
        {
            Employee = employee;
            User = user;
            Date = date;
            Hour = hour;
            Service = service;
            Status = status;
        }

        public Appointment(int idAppointment, Employee employee, User user, DateTime date, TimeSpan hour, Service service, string status)
        {
            IdAppointment = idAppointment;
            Employee = employee;
            User = user;
            Date = date;
            Hour = hour;
            Service = service;
            Status = status;
        }

        public static async Task CreateAppointment(Appointment appointment)
        {
            try
            {
                using (SqlConnection connection = Connection.Connect())
                {
                    await connection.OpenAsync();
                    string query = "INSERT INTO Appointments (UserId, EmployeeId, ServiceId, Date, Hour, Status) VALUES (@UserId, @EmployeeId, @ServiceId, @Date, @Hour, @Status)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", appointment.User.UserId);
                        command.Parameters.AddWithValue("@EmployeeId", appointment.Employee.IdEmployee);
                        command.Parameters.AddWithValue("@ServiceId", appointment.Service.IdService);
                        command.Parameters.AddWithValue("@Date", appointment.Date);
                        command.Parameters.AddWithValue("@Hour", appointment.Hour);
                        command.Parameters.AddWithValue("@Status", appointment.Status);
                        await command.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
                throw;
            }
        }

        public static async Task ModifyAppointment(Appointment appointment)
        {
            try
            {
                using (SqlConnection connection = Connection.Connect())
                {
                    await connection.OpenAsync();
                    string query = "UPDATE Appointments SET UserId = @UserId, EmployeeId = @EmployeeId, ServiceId = @ServiceId, Date = @Date, Hour = @Hour, Status = @Status WHERE AppointmentId = @AppointmentId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (appointment.User == null || appointment.Employee == null || appointment.Service == null)
                        {
                            throw new InvalidOperationException("La cita contiene referencias nulas.");
                        }

                        command.Parameters.AddWithValue("@UserId", appointment.User.UserId);
                        command.Parameters.AddWithValue("@EmployeeId", appointment.Employee.IdEmployee);
                        command.Parameters.AddWithValue("@ServiceId", appointment.Service.IdService);
                        command.Parameters.AddWithValue("@Date", appointment.Date);
                        command.Parameters.AddWithValue("@Hour", appointment.Hour);
                        command.Parameters.AddWithValue("@Status", appointment.Status);
                        command.Parameters.AddWithValue("@AppointmentId", appointment.IdAppointment);

                        await command.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
                throw;
            }
        }

        internal static async Task<List<Appointment>> GetAppointments()
        {
            using (SqlConnection connection = Connection.Connect())
            {
                await connection.OpenAsync();

                string query = @"SELECT * FROM Appointments WHERE Status = 'Pendiente'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    List<Appointment> appointments = new List<Appointment>();

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (reader.Read())
                        {
                            appointments.Add(new Appointment()
                            {
                                IdAppointment = int.Parse(reader["AppointmentId"].ToString()!),
                                Employee = await Employee.GetEmployeeById(int.Parse(reader["EmployeeId"].ToString()!)),
                                User = await User.GetUserById(int.Parse(reader["UserId"].ToString()!)),
                                Date = DateTime.Parse(reader["Date"].ToString()!),
                                Hour = TimeSpan.Parse(reader["Hour"].ToString()!),
                                Service = await Service.GetServiceById(int.Parse(reader["ServiceId"].ToString()!)),
                                Status = reader["Status"].ToString()!
                            });
                        }

                        return appointments;
                    }
                }
            }
        }

        public static async Task<Appointment> GetAppointmentById(int appointmentId)
        {
            try
            {
                using (SqlConnection connection = Connection.Connect())
                {
                    await connection.OpenAsync();
                    string query = "SELECT * FROM Appointments WHERE AppointmentId = @AppointmentId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AppointmentId", appointmentId);
                        SqlDataReader reader = await command.ExecuteReaderAsync();
                        if (reader.Read())
                        {
                            return new Appointment()
                            {
                                IdAppointment = int.Parse(reader["AppointmentId"].ToString()!),
                                Employee = await Employee.GetEmployeeById(int.Parse(reader["EmployeeId"].ToString()!)),
                                User = await User.GetUserById(int.Parse(reader["UserId"].ToString()!)),
                                Date = DateTime.Parse(reader["Date"].ToString()!),
                                Hour = TimeSpan.Parse(reader["Hour"].ToString()!),
                                Service = await Service.GetServiceById(int.Parse(reader["ServiceId"].ToString()!)),
                                Status = reader["Status"].ToString()!
                            };
                        }
                        return null!;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
                throw;
            }
        }


        public static async Task<List<Appointment>> GetAppointmentsByEmployee(Employee employee)
        {
            try
            {
                using (SqlConnection connection = Connection.Connect())
                {
                    await connection.OpenAsync();
                    string query = "SELECT * FROM Appointments WHERE EmployeeId = @EmployeeId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeId", employee.IdEmployee);
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            List<Appointment> appointments = new List<Appointment>();
                            while (await reader.ReadAsync())
                            {
                                appointments.Add(new Appointment()
                                {
                                    IdAppointment = int.Parse(reader["AppointmentId"].ToString()!),
                                    Employee = await Employee.GetEmployeeById(int.Parse(reader["EmployeeId"].ToString()!)),
                                    User = await User.GetUserById(int.Parse(reader["UserId"].ToString()!)),
                                    Date = DateTime.Parse(reader["Date"].ToString()!),
                                    Hour = TimeSpan.Parse(reader["Hour"].ToString()!),
                                    Service = await Service.GetServiceById(int.Parse(reader["ServiceId"].ToString()!)),
                                    Status = reader["Status"].ToString()!
                                });
                            }
                            return appointments;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
                throw;
            }
        }

        public static async Task<List<Appointment>> GetAppointmentsByUser(User user)
        {
            try
            {
                using (SqlConnection connection = Connection.Connect())
                {
                    await connection.OpenAsync();
                    string query = "SELECT * FROM Appointments WHERE UserId = @UserId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", user.UserId);
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            List<Appointment> appointments = new List<Appointment>();
                            while (await reader.ReadAsync())
                            {
                                appointments.Add(new Appointment()
                                {
                                    IdAppointment = int.Parse(reader["AppointmentId"].ToString()!),
                                    Employee = await Employee.GetEmployeeById(int.Parse(reader["EmployeeId"].ToString()!)),
                                    User = await User.GetUserById(int.Parse(reader["UserId"].ToString()!)),
                                    Date = DateTime.Parse(reader["Date"].ToString()!),
                                    Hour = TimeSpan.Parse(reader["Hour"].ToString()!),
                                    Service = await Service.GetServiceById(int.Parse(reader["ServiceId"].ToString()!)),
                                    Status = reader["Status"].ToString()!
                                });
                            }

                            return appointments;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
                throw;
            }
        }
    }
}
