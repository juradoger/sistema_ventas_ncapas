using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL.Examen210675213Dal
{
    public class _1ConsultaDal
    {
        public DataTable ListarClienteDal()
        {
            string consulta = "select persona.nombre NOMBRE, persona.apellido APELLIDO from persona, cliente where cliente.idpersona = persona.idpersona";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}
