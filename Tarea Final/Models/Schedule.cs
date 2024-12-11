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
        internal DateTime StartDay { get; set; }
        internal DateTime FinalDay { get; set; }
        internal TimeSpan StartHour { get; set; }
        internal TimeSpan FinalHour { get; set; }
        internal List<DateTime> BlockedDates { get; set; }

        internal Schedule(int idSchedule, int idEmployee, DateTime startDay, DateTime finalDay, TimeSpan startHour, TimeSpan finalHour)
        {
            IdSchedule = idSchedule;
            IdEmployee = idEmployee;
            StartDay = startDay;
            FinalDay = finalDay;
            StartHour = startHour;
            FinalHour = finalHour;
        }
        internal Schedule(int idSchedule, int idEmployee, DateTime startDay, DateTime finalDay, TimeSpan startHour, TimeSpan finalHour, List<DateTime> blockedDates)
        {
            IdSchedule = idSchedule;
            IdEmployee = idEmployee;
            StartDay = startDay;
            FinalDay = finalDay;
            StartHour = startHour;
            FinalHour = finalHour;
            BlockedDates = blockedDates;
        }

    }
}
