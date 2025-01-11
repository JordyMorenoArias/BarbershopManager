using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Final.Models
{
    internal class History
    {
        // Propiedades
        public int HistoryId { get; set; } // Identificador único del historial
        public int? UserId { get; set; } // ID del usuario (opcional)
        public string TableName { get; set; } // Nombre de la tabla afectada
        public string Action { get; set; } // Acción realizada (INSERT, UPDATE, DELETE)
        public DateTime ActionDate { get; set; } // Fecha y hora de la acción
        public string Details { get; set; } // Detalles adicionales sobre la acción

        // Constructor por defecto
        public History()
        {
            ActionDate = DateTime.Now; // Fecha y hora actuales por defecto
        }

        // Constructor con parámetros
        public History(int? userId, string tableName, string action, string details)
        {
            UserId = userId;
            TableName = tableName ?? throw new ArgumentNullException(nameof(tableName));
            Action = action ?? throw new ArgumentNullException(nameof(action));
            ActionDate = DateTime.Now; // Fecha actual al momento de crear el objeto
            Details = details;
        }

        // Constructor completo (incluyendo HistoryId)
        public History(int historyId, int? userId, string tableName, string action, DateTime actionDate, string details)
        {
            HistoryId = historyId;
            UserId = userId;
            TableName = tableName ?? throw new ArgumentNullException(nameof(tableName));
            Action = action ?? throw new ArgumentNullException(nameof(action));
            ActionDate = actionDate;
            Details = details;
        }

        public static async Task<List<History>> GetHistoriesByUser(User user)
        {
            using (SqlConnection connection = Connection.Connect())
            {
                string query = "SELECT * FROM History WHERE UserId = @UserId";
                await connection.OpenAsync();
                using (SqlCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", user.UserId);
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        List<History> histories = new();
                        while (await reader.ReadAsync())
                        {
                            histories.Add(new History(
                                historyId: (int)reader["HistoryId"],
                                userId: reader["UserId"] as int?,
                                tableName: reader["TableName"].ToString()!,
                                action: reader["Action"].ToString()!,
                                actionDate: (DateTime)reader["ActionDate"],
                                details: reader["Details"].ToString()!
                            ));
                        }
                        return histories;
                    }
                }
            }
        }
    }
}
