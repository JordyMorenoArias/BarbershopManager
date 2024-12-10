using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Final.Models
{
    internal class Conexion
    {
        private static SqlConnection? conexion { get; set; }

        public static SqlConnection Conectar()
        {
            if (conexion == null)
            {
                conexion = new SqlConnection(@"server=LAPTOP-SNNHEC4I; database=Proyecto_Final; integrated security = true; Encrypt=false");
            }
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Open();
            }
            return conexion;
        }
        public static void cerrar()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }

    }
}
