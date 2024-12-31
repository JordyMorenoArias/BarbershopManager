using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Final.Models
{
    internal class Schedule
    {
        internal int IdSchedule { get; set; }
        internal Appointment Appointment { get; set; }
        internal Employee Employee { get; set; }
        internal DateTime Date { get; set; }
        internal TimeSpan StartHour { get; set; }
        internal TimeSpan FinalHour { get; set; }
        internal List<DateTime> BlockedDates { get; set; }

        internal Schedule(Employee Employee, Appointment Appointment, DateTime day, TimeSpan Hour, TimeSpan duration)
        {
            this.Employee = Employee;
            this.Appointment = Appointment;
            Date = day;
            StartHour = Hour;
            FinalHour = Hour.Add(duration);
        }

        internal static async Task<List<Schedule>> GetSchedulesbyEmployee(int idEmployee)
        {
            List<Schedule> schedules = new();

            try
            {
                using (SqlConnection connection = Connection.Connect())
                {
                    await connection.OpenAsync();

                    string query = @"SELECT a.AppointmentId, a.Date, a.Hour, s.Duration 
                             FROM Appointments a 
                             JOIN Services s ON a.ServiceId = s.ServiceId 
                             WHERE EmployeeId = @EmployeeId AND a.Status = 'Pendiente'";

                    using (SqlCommand command = new(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeId", idEmployee);

                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                int appointmentId = (int)reader["AppointmentId"];
                                DateTime date = (DateTime)reader["Date"];
                                TimeSpan hour = (TimeSpan)reader["Hour"];
                                TimeSpan duration = (TimeSpan)reader["Duration"];

                                // Evita múltiples llamadas asíncronas dentro del bucle
                                var employee = await Employee.GetEmployeeById(idEmployee);
                                var appointment = await Appointment.GetAppointmentById(appointmentId);

                                schedules.Add(new Schedule(employee, appointment, date, hour, duration));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones, por ejemplo, registrar o lanzar la excepción
                throw new ApplicationException($"Error al obtener los horarios del empleado {idEmployee}: {ex.Message}", ex);
            }

            return schedules;
        }

    }
}
