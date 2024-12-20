using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Final.Models
{
    internal class Employee : User
    {
        internal int IdEmployee { get; set; }
        internal Schedule schedule { get; set; }

        internal Employee(string name, string email, string IdCard, string password, DateTime birthdate, string phonenumber, string UserId, int idEmployee, Schedule schedule)
            : base(name, email, IdCard, password, birthdate, phonenumber)
        {
            this.IdEmployee = idEmployee;
            this.schedule = schedule;
        }

        internal static async Task<Employee> GetEmployee(int employeeId)
        {
            using (SqlConnection connection = Connection.Connect())
            {
                string query = "SELECT * FROM Employees e JOIN Users u ON e.UserId = u.UserId WHERE e.EmployeeId = @EmployeeId";

                await connection.OpenAsync();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.Read())
                        {
                            return new Employee(
                                name: reader["Name"].ToString()!,
                                email: reader["Email"].ToString()!,
                                IdCard: reader["IdCard"].ToString()!,
                                password: reader["Password"].ToString()!,
                                birthdate: (DateTime)reader["Birthdate"],
                                phonenumber: reader["Phonenumber"].ToString()!,
                                UserId: reader["UserId"].ToString()!,
                                idEmployee: (int)reader["EmployeeId"],
                                schedule: null!
                            );
                        }
                        else
                        {
                            throw new InvalidOperationException("No se encontró un empleado con el ID dado.");
                        }
                    }
                }
            }
        }

        internal static List<Employee> GetEmployees()
        {
            using (SqlConnection connection = Connection.Connect())
            {
                string query = "SELECT * FROM Employees e JOIN Users u ON e.UserId = u.UserId";
                List<Employee> employees = new();
                connection.Open();
                using (SqlCommand command = new(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employees.Add(new Employee(
                                name: reader["Name"].ToString()!,
                                email: reader["Email"].ToString()!,
                                IdCard: reader["IdCard"].ToString()!,
                                password: reader["Password"].ToString()!,
                                birthdate: (DateTime)reader["Birthdate"],
                                phonenumber: reader["Phonenumber"].ToString()!,
                                UserId: reader["UserId"].ToString()!,
                                idEmployee: (int)reader["EmployeeId"],
                                schedule: null!
                            ));
                        }
                    }

                    return employees;
                }
            }
        }
    }
}

