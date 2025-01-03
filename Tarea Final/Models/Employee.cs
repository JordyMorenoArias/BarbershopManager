using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Tarea_Final.Models
{
    internal class Employee : User
    {
        internal int IdEmployee { get; set; }
        internal Schedule Schedule { get; set; }
        internal string Position { get; set; }
        internal DateTime Hiredate { get; set; }
        internal decimal Salary { get; set; }
        internal bool Status { get; set; }

        internal Employee() { }

        internal Employee(string name, string email, string IdCard, string password, DateTime birthdate, string phonenumber, string UserId, int idEmployee, Schedule schedule, string position, DateTime hiredate, decimal salary, bool status)
            : base(name, email, IdCard, password, birthdate, phonenumber)
        {
            this.IdEmployee = idEmployee;
            this.Schedule = schedule;
            this.Position = position;
            this.Hiredate = hiredate;
            this.Salary = salary;
            this.Status = status;
        }

        internal static async Task<Employee> GetEmployeeById(int employeeId)
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
                                schedule: null!,
                                position: reader["Position"].ToString()!,
                                hiredate: (DateTime)reader["Hiredate"],
                                salary: (decimal)reader["Salary"],
                                status: (bool)reader["Status"]!
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

        internal static async Task<Employee> GetEmployeeByName(string name)
        {
            using (SqlConnection connection = Connection.Connect())
            {
                string query = @"SELECT * FROM Employees e JOIN Users u ON e.UserId = u.UserId WHERE u.Name = @Name";

                await connection.OpenAsync();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
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
                                schedule: null!,
                                position: reader["Position"].ToString()!,
                                hiredate: (DateTime)reader["Hiredate"],
                                salary: (decimal)reader["Salary"],
                                status: (bool)reader["Status"]!
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

        internal static async Task CreateEmployee(Employee employee)
        {
            using (SqlConnection connection = Connection.Connect())
            {
                await connection.OpenAsync();

                string checkQuery = @"SELECT COUNT(*) FROM Employees WHERE UserId = @UserId";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@UserId", employee.UserId);
                    int count = (int)(await checkCommand.ExecuteScalarAsync() ?? 0);
                    if (count > 0)
                    {
                        throw new ApplicationException("El usuario ya esta contratado como empleado.");
                    }
                }

                string query = @"INSERT INTO Employees (UserId, Position, HireDate, Salary, Status) VALUES (@UserId, @Position, @HireDate, @Salary, @Status)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", employee.UserId);
                    command.Parameters.AddWithValue("@Position", employee.Position);
                    command.Parameters.AddWithValue("@HireDate", employee.Hiredate);
                    command.Parameters.AddWithValue("@Salary", employee.Salary);
                    command.Parameters.AddWithValue("@Status", employee.Status);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }
    }
}

