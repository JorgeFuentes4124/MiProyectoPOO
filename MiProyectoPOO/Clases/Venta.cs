using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiProyectoPOO.Clases
{
    public class Venta
    {
        public int idVenta { get; set; }
        public DateTime Fecha { get; set; }
        public Espectaculo Espectaculo { get; set; }
        public Ubicacion Ubicacion { get; set; }
        public Usuario Vendedor { get; set; }
        public int Cantidad { get; set; }
        public double Total { get; set; }

        public Venta(int idVenta, DateTime Fecha, Espectaculo Espectaculo, Usuario Vendedor, int Cantidad, double Total)
        {
            this.idVenta = idVenta;
            this.Fecha = Fecha;
            this.Espectaculo = Espectaculo;
            this.Vendedor = Vendedor;
            this.Cantidad = Cantidad;
            this.Total = Total;

        }

        public decimal CalculoTotal()
        {
            return 0;
        }

        public bool ValidarCapacidad()
        {
            return false;
        }
    }
}
