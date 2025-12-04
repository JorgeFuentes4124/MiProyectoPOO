using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiProyectoPOO.Datos;

namespace MiProyectoPOO.Clases
{
    public class Administrador : Usuario
    {
        public Administrador(int id, string Nombre, string Rol, string Contraseña) : base(id, Nombre, Rol, Contraseña)
        {
            Rol = "Administrador";
        }
        public void CrearEspectaculo(Espectaculo es)
        {
            // Enviar a la capa de datos para guardar en MySQL
            EspectaculoDatos.GuardarEspectaculo(es);
        }

        public void CrearUbicacion(Espectaculo es, Ubicacion ub)
        {
            UbicacionDatos.GuardarUbicacion(es.id, ub);
        }

        public void VerReporte(DateTime desde, DateTime hasta)
        {

            // Más adelante se usará la clase Reporte
        }
    }
}
