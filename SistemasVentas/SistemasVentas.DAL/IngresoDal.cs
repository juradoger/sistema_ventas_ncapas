﻿using SistemasVentas.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class IngresoDal
    {
        public DataTable ListarIngresoDal()
        {
            string consulta = "select * from ingreso";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarIngresoDal(Ingreso i)
        {
            string consulta = $"insert into ingreso values({i.IdProveedor}, '{i.FechaIngreso.ToString("yyyy-MM-dd HH:mm:ss.fff")}', {i.Total}, 'Activo')";
            Conexion.Ejecutar(consulta);
        }
        public Ingreso ObtenerIngresoId(int id)
        {
            string consulta = "select * from ingreso where idingreso=" + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            Ingreso ingreso = new Ingreso();
            if (tabla.Rows.Count > 0)
            {
                ingreso.IdIngreso = Convert.ToInt32(tabla.Rows[0]["idingreso"]);
                ingreso.IdProveedor = Convert.ToInt32(tabla.Rows[0]["idproveedor"]);
                ingreso.FechaIngreso = Convert.ToDateTime(tabla.Rows[0]["fechaingreso"]);
                ingreso.Total = Convert.ToDecimal(tabla.Rows[0]["total"]);
                ingreso.Estado = Convert.ToString(tabla.Rows[0]["estado"]);

            }
            return ingreso;
        }
    }
}
