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
        internal string IdCard { get; set; }
        internal string Password { get; set; }
        internal DateTime BirthDate { get; set; }
        internal string PhoneNumber { get; set; }

        internal User(int id, string name, string email, string idCard, string password, DateTime birthDate, string phoneNumber)
        {
            Id = id;
            Name = name;
            Email = email;
            IdCard = idCard;
            Password = password;
            BirthDate = birthDate;
            PhoneNumber = phoneNumber;
        }

        internal void ModifyUser(int userID)
        {
            // TODO: Implement this method
        }
        internal void CreateUser(User user) 
        {
            // TODO: Implement this method
        }
    }
}
