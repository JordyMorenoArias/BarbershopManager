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

        public Appointment() { }

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

        public void CreateAppointment(int idEmployee, int idUser, DateTime date, TimeSpan hour, Service service)
        {
            // TODO: Implement this method
        }

        public void CancelAppointment()
        {
            // TODO: Implement this method
        }

        public void ModifyAppointment(DateTime date, TimeSpan hour, Service service)
        {
            // TODO: Implement this method
        }

        public static List<Appointment> GetAppointments()
        {
            // TODO: Implement this method
            return new List<Appointment>();
        }

        public static List<Appointment> GetAppointmentsByUser(User user)
        {
            // TODO: Implement this method
            return new List<Appointment>();
        }

        public static List<Appointment> GetAppointmentsByEmployee(Employee employee)
        {
            // TODO: Implement this method
            return new List<Appointment>();
        }
    }
}
