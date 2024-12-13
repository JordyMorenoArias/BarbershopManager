using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Final.Models
{
    internal class Service
    {
        public int IdService { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public TimeSpan Duration { get; set; }

        public Service(int idService, string name, string description, decimal price, TimeSpan duration)
        {
            IdService = idService;
            Name = name;
            Description = description;
            Price = price;
            Duration = duration;
        }

        public static async Task<Service> GetServiceById(int idService)
        {
            using (SqlConnection connection = Connection.Connect())
            {
                connection.OpenAsync();
                string query = "SELECT * FROM Services WHERE ServiceId = @ServiceId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ServiceId", idService);
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.Read())
                        {
                            return new Service(
                                idService: (int)reader["ServiceId"],
                                name: reader["Name"].ToString(),
                                description: reader["Description"].ToString(),
                                price: (decimal)reader["Price"],
                                duration: (TimeSpan)reader["Duration"]
                            );
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public void CreateService(Service service)
        {
            // TODO: Implementar método
        }

        public void ModifyService(Service service)
        {
            // TODO: Implementar método
        }
        public void DeleteService(Service service)
        {
            // TODO: Implementar método
        }
    }
}
