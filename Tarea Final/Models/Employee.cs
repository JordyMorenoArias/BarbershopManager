using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Final.Models
{
    internal class Employee : User
    {
        internal string IdEmployee { get; set; }
        internal Schedule schedule { get; set; }

        internal Employee(int id, string name, string email, string idUser, string password, DateTime birthdate, string phonenumber, string idEmployee, Schedule schedule)
            : base(name, email, idUser, password, birthdate, phonenumber)
        {
            this.IdEmployee = idEmployee;
            this.schedule = schedule;
        }
    }
}

