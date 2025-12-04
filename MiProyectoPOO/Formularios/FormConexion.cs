using MiProyectoPOO.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiProyectoPOO.Formularios
{
    public partial class FormConexion : Form
    {
        private ConexionBD nConexion;
        public FormConexion()
        {
            InitializeComponent();
            nConexion = new ConexionBD();
        }

        private void FormConexion_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos.ConexionBD conexion = new Datos.ConexionBD();
            conexion.ObtenerConexion();
        }
    }
}
