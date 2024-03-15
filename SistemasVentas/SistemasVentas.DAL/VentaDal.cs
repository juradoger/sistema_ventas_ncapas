using SistemasVentas.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class VentaDal
    {
        public DataTable ListarVentaDal()
        {
            string consulta = "select * from venta";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarVentaDal(Venta v)
        {
            string consulta = $"insert into venta values({v.IdCliente},{v.IdVendedor}, '{v.fecha.ToString("yyyy-MM-dd HH:mm:ss.fff")}', {v.Total}, 'Exitoso')";
            Conexion.Ejecutar(consulta);
        }
    }
}
