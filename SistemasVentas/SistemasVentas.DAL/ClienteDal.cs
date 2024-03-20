﻿using SistemasVentas.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClienteDal()
        {
            string consulta = "select * from cliente";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarClienteDal(Cliente cliente)
        {
            string consulta = "insert into cliente values('" +cliente.IdPersona+ "' ," +
                                                          "'" +cliente.TipoCliente+ "' ," +
                                                          "'" +cliente.CodCliente+ "' ," +
                                                          "'Activo')";
            Conexion.Ejecutar(consulta);
        }
        public Cliente ObtenerIdCDal(int id)
        {
            string consulta = "select * from cliente where idcliente=" + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            Cliente cliente = new Cliente();
            if (tabla.Rows.Count > 0)
            {
                cliente.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                cliente.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                cliente.TipoCliente = tabla.Rows[0]["tipocliente"].ToString();
                cliente.CodCliente = tabla.Rows[0]["codcliente"].ToString();
                cliente.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return cliente;
        }
    }
}
