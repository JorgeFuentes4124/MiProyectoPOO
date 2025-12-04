using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MiProyectoPOO.Datos
{
    public class ConexionBD
    {
        private readonly string cadenaConexion;

        public ConexionBD()
        {
            string servidor = "localhost";
            string bd = "sistema_entradas";
            string usuario = "root";
            string password = ""; // pon tu contraseña si la tenés
            string puerto = "3306";

            cadenaConexion = $"Server={servidor};Database={bd};Uid={usuario};Pwd={password};Port={puerto};";
        }

        public MySqlConnection ObtenerConexion()
        {
            try
            {
                var conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la BD: " + ex.Message);
                return null;
            }
        }

        public void Cerrar(MySqlConnection conexion)
        {
            try
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }
            catch { /* ignorar */ }
        }
    }
}
