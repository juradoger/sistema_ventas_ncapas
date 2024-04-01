using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL.Examen210675213Dal
{
    public class _4ConsultaDal
    {
        public DataTable CantidadTotalProductoInventario()
        {
            string consulta = "SELECT PRODUCTO.NOMBRE, DETALLEING.CANTIDAD\r\nfrom PRODUCTO inner join DETALLEING on DETALLEING.IDPRODUCTO = PRODUCTO.IDPRODUCTO;\r\n";
            return Conexion.EjecutarDataTabla(consulta, "tabla");
        }
    }
}
