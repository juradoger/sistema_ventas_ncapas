using SistemasVentas.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class MarcaDal
    {
        public DataTable ListarMarcaDal()
        {
            string consulta = "select * from marca";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarMarcaDal(Marca m)
        {
            string consulta = $"insert into marca values('{m.Nombre.ToString()}', 'Activo')";
            Conexion.Ejecutar(consulta);
        }
        public Marca ObtenerIdMarca(int id)
        {
            string consulta = "select * from marca where idmarca=" + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            Marca marca = new Marca();
            if (tabla.Rows.Count > 0)
            {
                marca.IdMarca = Convert.ToInt32(tabla.Rows[0]["idmarca"]);
                marca.Nombre = tabla.Rows[0]["nombre"].ToString();
                marca.Telefono = tabla.Rows[0]["telefono"].ToString();
                marca.Direccion = tabla.Rows[0]["direccion"].ToString();
                marca.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return marca;
        }
    }
}
