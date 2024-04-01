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
        public Venta ObtenerVentaId(int id)
        {
            string consulta = "select * from venta where idventa=" + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            Venta venta = new Venta();
            if (tabla.Rows.Count > 0)
            {
                venta.IdVenta = Convert.ToInt32(tabla.Rows[0]["idventa"]);
                venta.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                venta.IdVendedor = Convert.ToInt32(tabla.Rows[0]["idvendedor"]);
                venta.fecha = Convert.ToDateTime(tabla.Rows[0]["fecha"]);
                venta.Total = Convert.ToInt32(tabla.Rows[0]["total"]);
                venta.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return venta;
        }
        public void EditarVentaDal(Venta p)
        {
            string consulta = "update venta set idcliente=" + p.IdCliente + "," +
                                                        "idvendedor=" + p.IdVendedor + "," +
                                                        "fecha='" + p.fecha + "', " +
                                                        "total=" + p.Total + "," +
                                                        "estado='" + p.Estado + "' " +
                                                "where idventa=" + p.IdVenta;
            Conexion.Ejecutar(consulta);
        }
        public void EliminarVentaDal(int id)
        {
            string consulta = "delete from venta where idventa=" + id;
            Conexion.Ejecutar(consulta);
        }
        public DataTable VentaDatosDal()
        {
            string consulta = "SELECT        VENTA.IDVENTA, VENTA.FECHA, VENTA.TOTAL, VENTA.ESTADO, PROVEEDOR.NOMBRE, CLIENTE.CODIGOCLIENTE\r\nFROM          VENTA, CLIENTE, PROVEEDOR\r\nWHERE\t\t  VENTA.IDCLIENTE=CLIENTE.IDCLIENTE AND VENTA.IDVENDEDOR=PROVEEDOR.IDPROVEEDOR;";
            return Conexion.EjecutarDataTabla(consulta, "sasaq");
        }
    }
}
