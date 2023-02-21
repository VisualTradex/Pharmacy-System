using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Farmacia_Bomy
{
    class Conexion
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conn = new SqlConnection("Data Source=HP-15-BS015LA;Initial Catalog=Proyecto;Integrated Security=True");
            conn.Open();
            return conn;
        }
    }
}
