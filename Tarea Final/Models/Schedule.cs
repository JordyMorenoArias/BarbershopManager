using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Final.Models
{
    internal class Schedule
    {
        internal int IdEmployee { get; set; }
        internal DateTime StartDay { get; set; }
        internal DateTime FinalDay { get; set; }
        internal TimeSpan StartHour { get; set; }
        internal TimeSpan FinalHour { get; set; }
        internal List<DateTime> BlockedDates { get; set; }

        internal Schedule(int idEmployee, DateTime startDay, DateTime finalDay, TimeSpan startHour, TimeSpan finalHour)
        {
            IdEmployee = idEmployee;
            StartDay = startDay;
            FinalDay = finalDay;
            StartHour = startHour;
            FinalHour = finalHour;
        }
        internal Schedule(int idEmployee, DateTime startDay, DateTime finalDay, TimeSpan startHour, TimeSpan finalHour, List<DateTime> blockedDates)
        {
            IdEmployee = idEmployee;
            StartDay = startDay;
            FinalDay = finalDay;
            StartHour = startHour;
            FinalHour = finalHour;
            BlockedDates = blockedDates;
        }

    }
}
