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
    }
}
