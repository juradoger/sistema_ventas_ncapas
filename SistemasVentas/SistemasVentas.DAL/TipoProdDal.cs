using SistemasVentas.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class TipoProdDal
    {
        public DataTable ListarTipoProdDal()
        {
            string consulta = "select * from tipoprod";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarTipoProdDal(TipoProducto e)
        {
            string consulta = $"insert into tipoprod values('{e.Nombre.ToString()}', 'Activo')";
            Conexion.Ejecutar(consulta);
        }
        TipoProducto tip = new TipoProducto();
        public TipoProducto ObtenerIdDal(int id)
        {
            string consulta = "select * from tipoprod where idtipoprod=" + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            
            if (tabla.Rows.Count > 0)
            {
                tip.IdTipoProd = Convert.ToInt32(tabla.Rows[0]["idtipoprod"]);
                tip.Nombre = tabla.Rows[0]["nombre"].ToString();
                tip.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return tip;
        }
        public void EditarTipoProdDal(TipoProducto p)
        {
            string consulta = "update tipoprod set nombre='" + p.Nombre + "'," +
                                                        "estado='" + p.Estado + "' " +
                                                "where idtipoprod=" + p.IdTipoProd;
            Conexion.Ejecutar(consulta);
        }
        public void EliminarTipoProdDal(int id)
        {
            string consulta = "delete from tipoprod where idtipoprod=" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
