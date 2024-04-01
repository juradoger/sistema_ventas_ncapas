using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelo;
//inyeccion de dependencias, ranged, scoll and singletown
namespace SistemasVentas.DAL
{
    public class PersonaDal
    {
        //funcion es esto public DataTable ListarPersonasDal(), una funcion es un codigo que  se ejecuta y devuelve un tipo de dato, aqui pido que me devuelva con return, ese dato debe ser compatible con el tipo de dato declarado en la funcion
        //al error cuando devuelves diferentes tipo de datos, se le llama error de compilacion
        public DataTable ListarPersonasDal()
        {
            string consulta = "select * from persona where estado = 'Activo'";
            //aqui llama a la funcion ejecutardatatabla
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarPersonaDal(Persona persona)
        {
            string consulta = "insert into persona values('" +persona.Nombre+ "' ,'" + persona.Apellido+ "' ,'" +persona.Telefono+ "' ,'" +persona.CI+ "','" + persona.Correo+ "'," + "'Activo')";
            Conexion.Ejecutar(consulta);
        }
        public Persona ObtenerPersonaId(int id)
        {
            //problema de la null enable, nulenali
            string consulta = "select * from persona where idpersona=" + id;//para filtrar
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            Persona persona = new Persona();
            if (tabla.Rows.Count > 0)
            {
                //pasamos a castear, lo que significa pasar a otra clase
 
                persona.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                persona.Nombre = tabla.Rows[0]["nombre"].ToString();
                persona.Apellido = tabla.Rows[0]["apellido"].ToString();
                persona.Telefono = tabla.Rows[0]["telefono"].ToString();
                persona.CI = tabla.Rows[0]["ci"].ToString();
                persona.Correo = tabla.Rows[0]["correo"].ToString();
                persona.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return persona;

        }
        public void EditarPersonaDal(Persona p)
        {
            string consulta = $"update persona set nombre= '{p.Nombre.ToString()}', apellido= '{p.Apellido.ToString()}', telefono='{p.Telefono.ToString()}', ci='{p.CI.ToString()}', correo='{p.Correo.ToString()}' where idpersona='{p.IdPersona}'";
            Conexion.Ejecutar(consulta);
        }
        public void EliminarPersonaDal(int id)
        {            
     //       string consulta = "delete from persona where idpersona="+id;
       //     Conexion.Ejecutar(consulta);
            string consul = "update persona set estado = 'Inactivo' where idpersona=" + id;
            Conexion.Ejecutar(consul);
        }
        
    }
}
