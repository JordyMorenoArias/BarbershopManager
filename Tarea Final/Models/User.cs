using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Final.Models
{
    internal class User
    {
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal string Email { get; set; }
        internal string IdUser { get; set; }
        internal string Password { get; set; }
        internal DateTime birthdate { get; set; }
        internal string phonenumber { get; set; }

        internal User(int id, string name, string email, string idUser, string password, DateTime birthdate, string phonenumber)
        {
            Id = id;
            Name = name;
            Email = email;
            IdUser = idUser;
            Password = password;
            this.birthdate = birthdate;
            this.phonenumber = phonenumber;
        }
    }
}
