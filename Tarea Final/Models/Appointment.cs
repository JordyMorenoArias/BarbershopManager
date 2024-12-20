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
        internal int IdEmployee { get; set; }
        internal int IdUser { get; set; }
        internal DateTime Date { get; set; }
        internal TimeSpan Hour { get; set; }
        internal Service Service { get; set; }
        internal string Status { get; set; }

        public Appointment(int idEmployee, int idUser, DateTime date, TimeSpan hour, Service service, string status)
        {
            IdEmployee = idEmployee;
            IdUser = idUser;
            Date = date;
            Hour = hour;
            Service = service;
            Status = status;
        }

        public Appointment(int idAppointment, int idEmployee, int idUser, DateTime date, TimeSpan hour, Service service, string status)
        {
            IdAppointment = idAppointment;
            IdEmployee = idEmployee;
            IdUser = idUser;
            Date = date;
            Hour = hour;
            Service = service;
            Status = status;
        }

        public static async Task CreateAppointment(Appointment appointment)
        {
            using (SqlConnection connection = Connection.Connect())
            {
                await connection.OpenAsync();
                string query = "INSERT INTO Appointments (UserId, EmployeeId, ServiceId, Date, Hour, Status) VALUES (@UserId, @EmployeeId, @ServiceId, @Date, @Hour, @Status)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", appointment.IdUser);
                    command.Parameters.AddWithValue("@EmployeeId", appointment.IdEmployee);
                    command.Parameters.AddWithValue("@ServiceId", appointment.Service.IdService);
                    command.Parameters.AddWithValue("@Date", appointment.Date);
                    command.Parameters.AddWithValue("@Hour", appointment.Hour);
                    command.Parameters.AddWithValue("@Status", appointment.Status);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public void CancelAppointment(Appointment appointment)
        {
            using (SqlConnection connection = Connection.Connect())
            {
                connection.Open();
                string query = "UPDATE Appointments SET Status = 'Cancelled' WHERE AppointmentId = @AppointmentId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AppointmentId", appointment.IdAppointment);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static async Task ModifyAppointment(Appointment appointment)
        {
            using (SqlConnection connection = Connection.Connect())
            {
                await connection.OpenAsync();
                string query = "UPDATE Appointments SET UserId = @UserId, EmployeeId = @EmployeeId, ServiceId = @ServiceId, Date = @Date, Hour = @Hour, Status = @Status WHERE AppointmentId = @AppointmentId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", appointment.IdUser);
                    command.Parameters.AddWithValue("@EmployeeId", appointment.IdEmployee);
                    command.Parameters.AddWithValue("@ServiceId", appointment.Service.IdService);
                    command.Parameters.AddWithValue("@Date", appointment.Date);
                    command.Parameters.AddWithValue("@Hour", appointment.Hour);
                    command.Parameters.AddWithValue("@Status", appointment.Status);
                    command.Parameters.AddWithValue("@AppointmentId", appointment.IdAppointment);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public static async Task<Appointment> GetAppointment(int appointemntId)
        {
            using (SqlConnection connection = Connection.Connect())
            {
                await connection.OpenAsync();
                string query = "SELECT * FROM Appointments WHERE AppointmentId = @AppointmentId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AppointmentId", appointemntId);
                    SqlDataReader reader = await command.ExecuteReaderAsync();
                    if (reader.Read())
                    {
                        return new Appointment(
                            reader.GetInt32(0), // AppointmentId
                            reader.GetInt32(1), // UserId
                            reader.GetInt32(2), // EmployeeId
                            reader.GetDateTime(4), // Date
                            reader.GetTimeSpan(5), // Hour
                            await Service.GetServiceById(reader.GetInt32(3)), // ServiceId
                            reader.GetString(6) // Status
                        );
                    }
                    return null;
                }
            }
        }

        public static async Task<List<Appointment>> GetAppointmentsByEmployee(Employee employee)
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
                            appointments.Add(new Appointment(
                                reader.GetInt32(0),
                                reader.GetInt32(1),
                                reader.GetInt32(2),
                                reader.GetDateTime(3),
                                reader.GetTimeSpan(4),
                                await Service.GetServiceById(reader.GetInt32(5)),
                                reader.GetString(6)
                            ));
                        }
                        return appointments;
                    }
                }
            }
        }


        public static async Task<List<Appointment>> GetAppointmentsByUser(User user)
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
                            appointments.Add(new Appointment(
                                reader.GetInt32(0), // AppointmentId
                                reader.GetInt32(1), // UserId
                                reader.GetInt32(2), // EmployeeId
                                reader.GetDateTime(4), // Date
                                reader.GetTimeSpan(5), // Hour
                                await Service.GetServiceById(reader.GetInt32(3)), // ServiceId
                                reader.GetString(6) // Status
                            ));
                        }
                        return appointments;
                    }
                }
            }
        }

        //public static async Task<List<Appointment>> GetAppointmentsByEmployee(Employee employee)
        //{
        //    string query = "SELECT * FROM Appointments WHERE EmployeeId = @EmployeeId";

        //    using (SqlConnection connection = Connection.Connect())
        //    {
        //        await connection.OpenAsync();

        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@EmployeeId", employee.IdEmployee);
        //            using (SqlDataReader reader = await command.ExecuteReaderAsync())
        //            {
        //                List<Appointment> appointments = new List<Appointment>();
        //                while (reader.Read())
        //                {
        //                    appointments.Add(new Appointment(idAppointment: (int)reader["AppointmentId"],
        //                                                     idEmployee: (int)reader["EmployeeId"],
        //                                                     idUser: (int)reader["UserId"],
        //                                                     date: (DateTime)reader["Date"],
        //                                                     hour: (TimeSpan)reader["Hour"],
        //                                                     service: await Service.GetServiceById((int)reader["ServiceId"]),
        //                                                     status: reader["Status"].ToString()));
        //                }
        //                return appointments;
        //            }
        //        }
        //    }
        //}
    }
}
