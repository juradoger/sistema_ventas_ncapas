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
            string consulta = "select * from persona";
            //aqui llama a la funcion ejecutardatatabla
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarPersonaDal(Persona persona)
        {
            string consulta = "insert into persona values('" +persona.Nombre+ "' ,'" + persona.Apellido+ "' ,'" +persona.Telefono+ "' ,'" +persona.CI+ "','" + persona.Correo+ "'," + "'Activo')";
            Conexion.Ejecutar(consulta);
        }
    }
}
