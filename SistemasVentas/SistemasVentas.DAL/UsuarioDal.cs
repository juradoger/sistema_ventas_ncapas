using SistemasVentas.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioDal
    {
        public DataTable ListarUsuarioDal()
        {
            string consulta = "select * from usuario";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioDal(Usuario i)
        {
            string consulta = $"insert into usuario values({i.IdPersona},'{i.NombreUser.ToString()}','{i.Contrasena.ToString()}', '{i.FechaReg.ToString("yyyy-MM-dd HH:mm:ss.fff")}')";
            Conexion.Ejecutar(consulta);
        }
        Usuario p = new Usuario();
        public Usuario ObtenerUsuarioIdDal(int id)
        {
            string consulta = "select * from usuario where idusuario=" + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                p.IdUsuario = Convert.ToInt32(tabla.Rows[0]["idusuario"]);
                p.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                p.NombreUser = tabla.Rows[0]["nombreuser"].ToString();
                p.Contrasena = tabla.Rows[0]["contrasena"].ToString();
                p.FechaReg = Convert.ToDateTime(tabla.Rows[0]["fechareg"]);
            }
            return p;
        }
        public void EditarUsuarioDal(Usuario p)
        {
            string consulta = "update usuario set idpersona=" + p.IdPersona + "," +
                                                        "nombreuser='" + p.NombreUser + "'," +
                                                        "contraseña='" + p.Contrasena + "'," +
                                                        "fechareg='" + p.FechaReg + "' " +
                                                "where idusuario=" + p.IdUsuario;
            Conexion.Ejecutar(consulta);
        }
        public void EliminarUsuarioDal(int id)
        {
            string consulta = "delete from usuario where idusuario=" + id;
            Conexion.Ejecutar(consulta);
        }
        public DataTable UsuariosDatosDal()
        {
            string consulta = "SELECT USUARIO.IDUSUARIO, (PERSONA.NOMBRE + ' ' + PERSONA.APELLIDO) NOMBRECOMPLETO, USUARIO.NOMBREUSER, ROL.NOMBRE AS NOMBREROL, USUARIOROL.FECHAASIGNA FROM PERSONA INNER JOIN USUARIO ON PERSONA.IDPERSONA = USUARIO.IDPERSONA INNER JOIN USUARIOROL ON USUARIO.IDUSUARIO = USUARIOROL.IDUSUARIO INNER JOIN ROL ON USUARIOROL.IDROL = ROL.IDROL";
            return Conexion.EjecutarDataTabla(consulta, "sfef");
        }
    }
}
    
