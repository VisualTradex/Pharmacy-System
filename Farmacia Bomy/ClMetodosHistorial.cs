using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Farmacia_Bomy
{
    class ClMetodosHistorial
    {
        public static int InsertarHistorial(ClHistorial x)
        {
            int retorno = 0;
            SqlConnection conn = Conexion.ObtenerConexion();
            string sql = "insert into Historial values(@Nombre,@Fecha,@Hora,@TotalDeCompra)";
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.Parameters.AddWithValue("@Nombre", x.Nombre1);
            comando.Parameters.AddWithValue("@Fecha", x.Fecha1);
            comando.Parameters.AddWithValue("@Hora", x.Hora1);
            comando.Parameters.AddWithValue("@TotalDeCompra", x.TotalCompra1);
            retorno = comando.ExecuteNonQuery();
            conn.Close();
            return retorno;
        }
    }
}
