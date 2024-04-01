using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL.Examen210675213Dal
{
    public class _3ConsultaDal
    {
        public DataTable MarcaMasVendida()
        {
            string consulta = "SELECT  MARCA.NOMBRE, COUNT (*) AS NROVECES,(SELECT SUM(DETALLEVENTA.CANTIDAD)) AS CCANTIDAD\r\nFROM MARCA INNER JOIN PRODUCTO left JOIN DETALLEVENTA ON DETALLEVENTA.IDPRODUCTO = PRODUCTO.IDPRODUCTO ON \r\nPRODUCTO.IDMARCA = MARCA.IDMARCA\r\nGROUP BY MARCA.NOMBRE\r\nHAVING SUM(DETALLEVENTA.CANTIDAD)>20";
            return Conexion.EjecutarDataTabla(consulta, "tabla");
        }
        
       
    }
}
