using SistemasVentas.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProveeDal
    {
        public DataTable ListarProveeDal()
        {
            string consulta = "select * from provee";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarProveeDal(Provee p)
        {
            string consulta = $"insert into provee values({p.IdProducto}, {p.IdProveedor},'{p.Fecha.ToString("yyyy-MM-dd HH:mm:ss.fff")}',{p.Precio})";
            Conexion.Ejecutar(consulta);
        }
        Provee p = new Provee();
        public Provee ObtenerProveeIdDal(int id)
        {
            string consulta = "select * from provee where idprovee=" + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                p.IdProvee = Convert.ToInt32(tabla.Rows[0]["idprovee"]);
                p.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                p.IdProveedor = Convert.ToInt32(tabla.Rows[0]["idproveedor"]);
                p.Fecha = Convert.ToDateTime(tabla.Rows[0]["fecha"]);
                p.Precio = Convert.ToDecimal(tabla.Rows[0]["precio"]);
            }
            return p;
        }
        public void EditarProveeDal(Provee p)
        {
            string consulta = "update provee set idproducto=" + p.IdProducto + "," +
                                                        "idproveedor=" + p.IdProveedor + "," +
                                                        "fecha='" + p.Fecha + "'," +
                                                        "precio=" + p.Precio + " " +
                                                "where idprovee=" + p.IdProvee;
            Conexion.Ejecutar(consulta);
        }
        public void EliminarProveeDal(int id)
        {
            string consulta = "delete from provee where idprovee=" + id;
            Conexion.Ejecutar(consulta);
        }
        public DataTable ProveeDatosDal()
        {
            string consulta = "SELECT        PROVEE.IDPROVEE, PROVEE.FECHA, PROVEE.PRECIO, PRODUCTO.NOMBRE, PRODUCTO.CODIGOBARRA, PRODUCTO.DESCRIPCION, PROVEEDOR.NOMBRE PROVEEDOR\r\nFROM            PROVEE INNER JOIN\r\n                         PRODUCTO ON PROVEE.IDPRODUCTO = PRODUCTO.IDPRODUCTO INNER JOIN\r\n                         PROVEEDOR ON PROVEE.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR";
            return Conexion.EjecutarDataTabla(consulta, "dasa");
        }
    }
}

