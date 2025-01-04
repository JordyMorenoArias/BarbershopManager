using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Final.Models
{
    public class User
    {
        internal int UserId { get; set; }
        internal string Name { get; set; } = string.Empty;
        internal string Email { get; set; } = string.Empty;
        internal string IdCard { get; set; } = string.Empty;
        internal string Password { get; set; } = string.Empty;
        internal DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        internal bool IsAdmin { get; set; } = false;

        internal User() { }

        internal User(string name, string email, string idCard, string password, DateTime birthDate, string phoneNumber)
        {
            Name = name;
            Email = email;
            IdCard = idCard;
            Password = password;
            BirthDate = birthDate;
            PhoneNumber = phoneNumber;
        }

        internal static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        internal static async Task<User> ValidateUser(string email, string password)
        {
            using (SqlConnection connection = Connection.Connect())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    await connection.OpenAsync();
                }

                string query = "SELECT * FROM Users WHERE Email = @Email AND Password = @Password";
                using (SqlCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", HashPassword(password));

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return new User
                            {
                                UserId = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Email = reader.GetString(2),
                                IdCard = reader.GetString(3),
                                Password = reader.GetString(4),
                                BirthDate = reader.GetDateTime(5),
                                PhoneNumber = reader.GetString(6),
                                IsAdmin = reader.GetBoolean(7)
                            };
                        }
                        else
                        {
                            throw new ApplicationException("El correo electrónico o la contraseña son incorrectos.");
                        }
                    }
                }
            }
        }

        internal static async Task CreateUser(User user)
        {

            using (SqlConnection connection = Connection.Connect())
            {
                await connection.OpenAsync();

                // Verificar si el correo electrónico ya existe
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                using (SqlCommand checkCommand = new (checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Email", user.Email);
                    int emailCount = (int)(await checkCommand.ExecuteScalarAsync() ?? 0);
                    if (emailCount > 0)
                    {
                        throw new ApplicationException("El correo electrónico ya está registrado.");
                    }
                }

                // Insertar el nuevo usuario
                string query = "INSERT INTO Users (Name, Email, IdCard, Password, BirthDate, PhoneNumber) VALUES (@Name, @Email, @IdCard, @Password, @BirthDate, @PhoneNumber)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", user.Name);
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.Parameters.AddWithValue("@IdCard", user.IdCard);
                    command.Parameters.AddWithValue("@Password", HashPassword(user.Password));
                    command.Parameters.AddWithValue("@BirthDate", user.BirthDate);
                    command.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        internal static async Task<User> GetUserById(int id)
        {
            try
            {
                using (SqlConnection connection = Connection.Connect())
                {
                    await connection.OpenAsync();
                    string query = "SELECT * FROM Users WHERE UserId = @UserId";
                    using (SqlCommand command = new(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", id);
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                return new User
                                {
                                    UserId = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Email = reader.GetString(2),
                                    IdCard = reader.GetString(3),
                                    Password = reader.GetString(4),
                                    BirthDate = reader.GetDateTime(5),
                                    PhoneNumber = reader.GetString(6)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw new ApplicationException("Se ha producido un error al obtener el usuario.", ex);
            }

            return null!;
        }

        internal static async Task<User> GetUserByIdCard(string idCard)
        {
            try
            {
                using (SqlConnection connection = Connection.Connect())
                {
                    await connection.OpenAsync();
                    string query = "SELECT * FROM Users WHERE IdCard = @IdCard";
                    using (SqlCommand command = new(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdCard", idCard);
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                return new User
                                {
                                    UserId = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Email = reader.GetString(2),
                                    IdCard = reader.GetString(3),
                                    Password = reader.GetString(4),
                                    BirthDate = reader.GetDateTime(5),
                                    PhoneNumber = reader.GetString(6)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw new ApplicationException("Se ha producido un error al obtener el usuario.", ex);
            }
            return null!;
        }

        internal static async Task ModifyUser(User user)
        {
            try
            {
                using (SqlConnection connection = Connection.Connect())
                {
                    await connection.OpenAsync();
                    string query = "UPDATE Users SET Name = @Name, Email = @Email, IdCard = @IdCard, Password = @Password, BirthDate = @BirthDate, PhoneNumber = @PhoneNumber WHERE UserId = @UserId";

                    using (SqlCommand command = new(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", user.Name);
                        command.Parameters.AddWithValue("@Email", user.Email);
                        command.Parameters.AddWithValue("@IdCard", user.IdCard);
                        command.Parameters.AddWithValue("@Password", HashPassword(user.Password));
                        command.Parameters.AddWithValue("@BirthDate", user.BirthDate);
                        command.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                        command.Parameters.AddWithValue("@UserId", user.UserId);
                        await command.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw new ApplicationException("Se ha producido un error al modificar el usuario.", ex);
            }
        }
    }
}
