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
    public static class VentaDatos
    {
        public static void GuardarVenta(Venta v)
        {
            ConexionBD db = new ConexionBD();
            using (var conexion = db.ObtenerConexion())

            {
                conexion.Open();
                string query = "INSERT INTO ventas (Fecha, IdEspectaculo, IdUbicacion, IdVendedor, Cantidad, Total) " +
                               "VALUES (@f, @e, @u, @v, @c, @t)";
                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@f", v.Fecha);
                    cmd.Parameters.AddWithValue("@e", v.Espectaculo.id);
                    cmd.Parameters.AddWithValue("@u", v.Ubicacion.id);
                    cmd.Parameters.AddWithValue("@v", v.Vendedor.Id);
                    cmd.Parameters.AddWithValue("@c", v.Cantidad);
                    cmd.Parameters.AddWithValue("@t", v.Total);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
