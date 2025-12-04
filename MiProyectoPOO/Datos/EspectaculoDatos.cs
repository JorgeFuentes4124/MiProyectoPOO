using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiProyectoPOO.Clases;
using MySql.Data.MySqlClient;

namespace MiProyectoPOO.Datos
{
    public static class EspectaculoDatos
    {
        public static void GuardarEspectaculo(Espectaculo e)
        {
            ConexionBD db = new ConexionBD();
            using (var conexion = db.ObtenerConexion())

            {
                conexion.Open();
                string query = "INSERT INTO espectaculos (Nombre, CapacidadTotal, PrecioBase, Foto) VALUES (@n, @c, @p, @f)";
                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@n", e.Nombre);
                    cmd.Parameters.AddWithValue("@c", e.CapacidadTotal);
                    cmd.Parameters.AddWithValue("@p", e.PrecioBase);
                    cmd.Parameters.AddWithValue("@f", e.Foto);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
