﻿using SistemasVentas.DAL;
using SistemasVentas.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class ProductoBss
    {
        ProductoDal dal = new ProductoDal();
        public DataTable ListarProductoBss()
        {
            return dal.ListarProductoDal();
        }
        public void InsertarProductoBss(Producto pr)
        {
            dal.InsertarProductoDal(pr);
        }
        public Producto ObtenerIdPBss(int id)
        {
            return dal.ObtenerProductoId(id);
        }
    }
}
