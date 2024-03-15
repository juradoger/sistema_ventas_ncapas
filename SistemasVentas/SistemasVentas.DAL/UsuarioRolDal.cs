using SistemasVentas.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioRolDal
    {
        public DataTable ListarUsuarioRolDal()
        {
            string consulta = "select * from usuariorol";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioRolDal(UsuarioRol dv)
        {
            string consulta = $"insert into usuariorol values({dv.IdUsuario}, {dv.IdRol}, '{dv.FechaAsig.ToString("yyyy-MM-dd HH:mm:ss.fff")}', 'Exitoso')";
            Conexion.Ejecutar(consulta);
        }
       

    }
}
