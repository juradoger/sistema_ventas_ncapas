﻿using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class RolBss
    {

        RolDal dal = new RolDal();
        public DataTable ListarRolBss()
        {
            return dal.ListarRolDal();
        }
    }
}
