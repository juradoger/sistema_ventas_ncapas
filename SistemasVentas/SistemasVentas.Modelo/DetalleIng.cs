using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelo
{
    public class DetalleIng
    {
        public int IdDetalleIng { get; set; }
        public int IdIngreso { get; set; }
        public int IdProducto { get; set; }
        public DateTime FechaVenc { get; set; }
        public int Cantidad { get; set; }   
        public double PrecioCosto { get; set; }
        public double PrecioVenta { get; set; }
        public double Subtotal { get; set; }
        public string Estado { get; set; }



    }
}
