using SistemasVentas.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class DetalleVentaDal
    {
        public DataTable ListarDetalleVentaDal()
        {
            string consulta = "select * from detalleventa";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarDetalleVentaDal(DetalleVenta dv)
        {
            string consulta = $"insert into detalleventa values({dv.IdVenta}, {dv.IdProducto}, {dv.Cantidad}, {dv.PrecioVenta}, {dv.Subtotal}, 'Exitoso')";
            Conexion.Ejecutar(consulta);
        }
    }

}
