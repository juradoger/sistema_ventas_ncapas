using SistemasVentas.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class IngresoDal
    {
        public DataTable ListarIngresoDal()
        {
            string consulta = "select * from ingreso";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarIngresoDal(Ingreso i)
        {
            string consulta = $"insert into ingreso values({i.IdProveedor}, '{i.FechaIngreso.ToString("yyyy-MM-dd HH:mm:ss.fff")}', {i.Total}, 'Activo')";
            Conexion.Ejecutar(consulta);
        }
    }
}
