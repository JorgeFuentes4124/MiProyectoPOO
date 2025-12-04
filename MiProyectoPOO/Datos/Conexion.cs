using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MiProyectoPOO.Datos
{
    class ConexionBD
    {
        MySqlConnection conexion = new MySqlConnection();
        static string servidor = "localhost";
        static string bd = "sistema_entradas";
        static string usuario = "root";
        static string password = "";
        static string puerto = "3306";
        string cadenaConexion =
                        "server=" + servidor +
                        ";database=" + bd +
                        ";user=" + usuario +
                        ";password=" + password +
                        ";port=" + puerto + ";";


        public MySqlConnection ObtenerConexion()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                MessageBox.Show("Se Conecto a la BD Correctamente");
            }

            catch (MySqlException e)
            {
                MessageBox.Show("No se Conecto Correctamente a la BD" + e.ToString());
            }

            return conexion;
        }



    }
}
