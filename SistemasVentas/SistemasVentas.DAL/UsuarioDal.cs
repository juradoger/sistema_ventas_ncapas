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
    }
}
