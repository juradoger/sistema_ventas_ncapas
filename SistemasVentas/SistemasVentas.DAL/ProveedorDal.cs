using SistemasVentas.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProveedorDal
    {
        public DataTable ListarProveedorDal()
        {
            string consulta = "select * from proveedor";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarProveedorDal(Proveedor p)
        {
            string consulta = $"insert into proveedor values('{p.Nombre.ToString()}', '{p.Telefono.ToString()}','{p.Direccion.ToString()}','Activo')";
            Conexion.Ejecutar(consulta);
        }
    }
}
