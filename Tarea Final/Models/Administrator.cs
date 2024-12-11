using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Final.Models
{
    internal class Administrator: User
    {

        internal Administrator(int id, string name, string email, string idUser, string password, DateTime birthDate, string phoneNumber) : base(name, email, idUser, password, birthDate, phoneNumber)
        {
        }

        internal void FireEmployee(Employee Employee)
        {
            // TODO: Implement this method
        }

        internal void ModifyEmployee(Employee Employee)
        {
            // TODO: Implement this method
        }
    }
}
