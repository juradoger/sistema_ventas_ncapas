using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL.Examen210675213Dal
{
    public class _5ConsultaDal
    {
        public DataTable ProductoProxExpirar()
        {
            string consulta = "SELECT PRODUCTO.NOMBRE, DETALLEING.FECHAVENC\r\nfrom PRODUCTO inner join DETALLEING on DETALLEING.IDPRODUCTO = PRODUCTO.IDPRODUCTO\r\nWHERE DETALLEING.FECHAVENC <= CAST('2024-04-01 00:00:00' AS datetime)";
            return Conexion.EjecutarDataTabla(consulta, "tabla");
        }
    }
}
