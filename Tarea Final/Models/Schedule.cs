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
        internal int IdEmployee { get; set; }
        internal DateTime Date { get; set; }
        internal TimeSpan StartHour { get; set; }
        internal TimeSpan FinalHour { get; set; }
        internal List<DateTime> BlockedDates { get; set; }

        internal Schedule(int idEmployee, DateTime day, TimeSpan Hour, TimeSpan duration)
        {
            IdEmployee = idEmployee;
            Date = day;
            StartHour = Hour;
            FinalHour = Hour.Add(duration);
        }

        internal Schedule(int idSchedule, int idEmployee, DateTime startDay, DateTime finalDay, TimeSpan startHour, TimeSpan finalHour, List<DateTime> blockedDates)
        {
            IdSchedule = idSchedule;
            IdEmployee = idEmployee;
            Date = startDay;
            StartHour = startHour;
            FinalHour = finalHour;
            BlockedDates = blockedDates;
        }

        internal static async Task<List<Schedule>> GetSchedulesbyEmployee(int idEmployee)
        {
            List<Schedule> schedules = new();
            using (SqlConnection connection = Connection.Connect())
            {
                await connection.OpenAsync();
                string query = "SELECT a.Date, a.Hour, s.Duration FROM Appointments a JOIN Services s ON a.ServiceId = s.ServiceId WHERE EmployeeId = @EmployeeId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeId", idEmployee);

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            DateTime date = (DateTime)reader["Date"];
                            TimeSpan hour = (TimeSpan)reader["Hour"];
                            TimeSpan duration = (TimeSpan)reader["Duration"];
                            schedules.Add(new Schedule(idEmployee, date, hour, duration));
                        }
                    }
                }

            }
            return schedules;
        }
    }
}
