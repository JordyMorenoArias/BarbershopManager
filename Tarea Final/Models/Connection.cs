using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Final.Models
{
    internal class Connection
    {
        private static readonly object lockObject = new();

        private Connection() { }

        public static SqlConnection Connect()
        {
            lock (lockObject)
            {
                return new SqlConnection(@"server=LAPTOP-989OF5PS\MSSQLSERVER02;database=SistemaGestionDB;integrated security=true;Encrypt=false");
            }
        }
    }
}
