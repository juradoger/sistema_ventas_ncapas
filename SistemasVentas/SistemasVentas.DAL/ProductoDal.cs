using SistemasVentas.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProductoDal
    {
        public DataTable ListarProductoDal()
        {
            string consulta = "select * from producto";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarProductoDal(Producto p)
        {
            string consulta = $"insert into producto values({p.IdTipoProd}, {p.IdMarca},'{p.Nombre.ToString()}','{p.CodigoBarra.ToString()}',{p.Unidad},'{p.Descripcion.ToString()}','Activo')";
            Conexion.Ejecutar(consulta);
        }
        public Producto ObtenerProductoId(int id)
        {
            string consulta = "select * from producto where idproducto=" + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            Producto producto = new Producto();
            if (tabla.Rows.Count > 0)
            {
                producto.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                producto.IdTipoProd = Convert.ToInt32(tabla.Rows[0]["idtipoprod"]);
                producto.IdMarca = Convert.ToInt32(tabla.Rows[0]["idmarca"]);
                producto.Nombre = tabla.Rows[0]["nombre"].ToString();
                producto.CodigoBarra = tabla.Rows[0]["codigobarra"].ToString();
                producto.Unidad = Convert.ToInt32(tabla.Rows[0]["unidad"]);
                producto.Descripcion = tabla.Rows[0]["descripcion"].ToString();
                producto.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return producto;
        }
    }
}
