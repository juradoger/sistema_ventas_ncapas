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
        UsuarioRol p = new UsuarioRol();
        public UsuarioRol ObtenerUsuarioRolIdDal(int id)
        {
            string consulta = "select * from usuariorol where idusuariorol=" + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {

                p.IdUsuarioRol = Convert.ToInt32(tabla.Rows[0]["idusuariorol"]);
                p.IdUsuario = Convert.ToInt32(tabla.Rows[0]["idusuario"]);
                p.IdRol = Convert.ToInt32(tabla.Rows[0]["idrol"]);
                p.FechaAsig = Convert.ToDateTime(tabla.Rows[0]["fechaasigna"]);
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;
        }
        public void EditarUsuarioRolDal(UsuarioRol p)
        {
            string consulta = "update usuariorol set idusuario=" + p.IdUsuario + "," +
                                                        "idrol=" + p.IdRol + "," +
                                                        "fechaasigna='" + p.FechaAsig + "', " +
                                                        "estado='" + p.Estado + "' " +
                                                "where idusuariorol=" + p.IdUsuarioRol;
            Conexion.Ejecutar(consulta);
        }
        public void EliminarUsuarioRolDal(int id)
        {
            string consulta = "delete from usuariorol where idusuariorol=" + id;
            Conexion.Ejecutar(consulta);
        }
        public DataTable UsuarioRolDatosDal()
        {
            string consulta = "SELECT        USUARIOROL.IDUSUARIOROL, USUARIOROL.FECHAASIGNA, USUARIO.NOMBREUSER USUARIO, ROL.NOMBRE ROL, USUARIOROL.ESTADO\r\nFROM            USUARIOROL INNER JOIN\r\n                         USUARIO ON USUARIOROL.IDUSUARIO = USUARIO.IDUSUARIO INNER JOIN\r\n                         ROL ON USUARIOROL.IDROL = ROL.IDROL";
            return Conexion.EjecutarDataTabla(consulta, "ssdsa");
        }

    }
}
