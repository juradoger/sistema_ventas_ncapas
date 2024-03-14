using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemasVentas.DAL
{
    public class Conexion
    {
        /// <summary>
        /// Esta clase me ayuda a conectarme con la BD, es una app insegura porque lleva la autenticacion de windows
        /// En las nuevas versiones, TrustServerCertificate=true; esto dice que es seguro
        /// aqui va el nombre de la BD que me pidio al instalar, el nombre de mi computaora, Data Source=(local)
        /// </summary>
        public static string CONECTAR
        {
            get { return @"Data Source=LAPTOP-8ARPEK3R\SQLNAYELI; Initial Catalog=BDTIENDA; Integrated Security=True; TrustServerCertificate=true;"; }
            //get { return ConfigurationManager.ConnectionStrings["cadena"].ToString(); }
        }
        public static DataSet EjecutarDataSet(string consulta)
        {
            string p = Conexion.CONECTAR;
            SqlConnection conectar = new SqlConnection(Conexion.CONECTAR);
            conectar.Open();
            SqlCommand cmd = new SqlCommand(consulta, conectar);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "TABLA");
            return ds;
        }
        /// Este metodo me dice que va a recibir una consulta, ese metodo es estatico, y cuando uso una consulta tipo escalar quiere decir que va a devolver un dato escalar o calculado, con funciones como SUM, MAX, MIN, COUNT y AVG

        public static void Ejecutar(string consulta)
        {
            SqlConnection conectar = new SqlConnection(Conexion.CONECTAR);
            conectar.Open();
            SqlCommand cmd = new SqlCommand(consulta, conectar);
            cmd.CommandTimeout = 5000;
            cmd.ExecuteNonQuery();
        }

        public static int EjecutarEscalar(string consulta)
        {
            SqlConnection conectar = new SqlConnection(Conexion.CONECTAR);
            conectar.Open();

            SqlCommand cmd = new SqlCommand(consulta, conectar);
            cmd.CommandTimeout = 5000;
            int dev = Convert.ToInt32(cmd.ExecuteScalar());
            return dev;
        }

        /// 
        public static DataTable EjecutarDataTabla(string consulta, string tabla)
        {
            string p = Conexion.CONECTAR;
            SqlConnection conectar = new SqlConnection(Conexion.CONECTAR);
            SqlCommand cmd = new SqlCommand(consulta, conectar);
            cmd.CommandTimeout = 5000;
            SqlDataAdapter da = new SqlDataAdapter();//recupera toda la lista o todos los registros que se han hecho
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(tabla);//mas legible se puede manipular desde un listview, es manipulable para cualquier entorno
            da.Fill(dt);
            return dt;
        }

    }
}
