using SistemasVentas.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SistemasVentas.DAL
{
    public class DetalleIngDal
    {
        public DataTable ListarDetalleIngDal()
        {
            string consulta = "select * from DetalleIng";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarDetalleIngDal(DetalleIng d)
        {
            /*string consulta = "insert into detalleing values("+d.IdIngreso+ ","+d.IdProducto+ " ,'"+d.FechaVenc+"' ,"+d.Cantidad+" ," +d.PrecioCosto+" ," +d.PrecioVenta+ " ," +d.Subtotal+ " ," +"'Exitoso')";*/

            string consulta = $"insert into detalleing values({d.IdIngreso}, {d.IdProducto}, '{d.FechaVenc.ToString("yyyy-MM-dd HH:mm:ss.fff")}', {d.Cantidad}, {d.PrecioCosto}, {d.PrecioVenta}, {d.Subtotal}, 'Exitoso')";
            //2023-06-11 10:18:40.000

            //"insert into detalleing values(1, 1, '14/3/2024 22:58:42', 12, 123, 345, 342, 'Exitoso')"

            //"insert into detalleing values(1, 1, '2024-03-14 23:04:27.605', 21, 234, 231, 453, 'Exitoso')"


            Conexion.Ejecutar(consulta);
        }

    }
}
