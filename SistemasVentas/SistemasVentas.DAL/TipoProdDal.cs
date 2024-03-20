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
            string consulta = $"insert into rol values('{e.Nombre.ToString()}', 'Activo')";
            Conexion.Ejecutar(consulta);
        }
        public TipoProducto ObtenerIdDal(int id)
        {
            string consulta = "select * from tipoproducto where idtipoprod=" + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            TipoProducto tip = new TipoProducto();
            if (tabla.Rows.Count > 0)
            {
                tip.IdTipoProd = Convert.ToInt32(tabla.Rows[0]["idtipoprod"]);
                tip.Nombre = tabla.Rows[0]["nombre"].ToString();
                tip.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return tip;
        }
    }
}
