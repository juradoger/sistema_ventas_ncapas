using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL.Examen210675213Dal
{
    public class _2ConsultaDal
    {
        public DataTable CalcularTotalIngresosPorVendedor()
        {
            string consulta = "select pro.NOMBRE PROVEEDOR, count(*) CANTIDAD,(SELECT SUM(ing.TOTAL))as TOTALINGRESOS\r\nfrom ingreso ing inner join proveedor pro on ing.IDPROVEEDOR = pro.IDPROVEEDOR\r\ngroup by pro.NOMBRE";
            return Conexion.EjecutarDataTabla(consulta, "tabla");

        }
    }
}
