using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiProyectoPOO.Datos;

namespace MiProyectoPOO.Clases
{
    public class Vendedor : Usuario
    {
        public Vendedor(int id, string Nombre, string Rol, string Contraseña) : base(id, Nombre, Rol, Contraseña)
        {
            Rol = "Vendedor";
        }

        public void RegistrarVenta(Venta v)
        {
            if (v.ValidarCapacidad())
            {
                VentaDatos.GuardarVenta(v);
                v.Ubicacion.RegistrarVenta(v.Cantidad);
            }
            else
            {
                throw new Exception("No hay suficiente capacidad disponible.");
            }
        }

        public bool VerificarDisponibilidad(Ubicacion u, int cantidad)
        {
            return u.HayDisponibilidad(cantidad);
        }
    }
}
