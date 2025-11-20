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
        private Conexion nConexion;
        public FormConexion()
        {
            InitializeComponent();
            nConexion = new Conexion();
        }

        private void FormConexion_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos.Conexion conexion = new Datos.Conexion();
            conexion.establecerConexion();
        }
    }
}
