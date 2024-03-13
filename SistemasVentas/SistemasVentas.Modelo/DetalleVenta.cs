using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelo
{
    public class DetalleVenta
    {
        public int IdDetalleVenta { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public  int Cantidad { get; set; }
        public double PrecioVenta { get; set; }
        public double Subtotal { get; set; }
        public string Estado { get; set; }

    }
}
