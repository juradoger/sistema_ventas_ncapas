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
    }
}
