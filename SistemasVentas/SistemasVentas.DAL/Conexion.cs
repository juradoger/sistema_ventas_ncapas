﻿using System;
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
        
        public static string CONECTAR
        {
            get { return @"Data Source=LAPTOP-8ARPEK3R\SQLNAYELI; Initial Catalog=TIENDABD; Integrated Security=True; TrustServerCertificate=true;"; }
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
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(tabla);
            da.Fill(dt);
            return dt;
        }

    }
}
