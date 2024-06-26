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
    public class UsuarioRolBss
    {
        UsuarioRolDal dal = new UsuarioRolDal();
        public DataTable ListarUsuarioRolBss()
        {
            return dal.ListarUsuarioRolDal();
        }
        public void InsertarUsuarioRolBss(UsuarioRol mar)
        {
            dal.InsertarUsuarioRolDal(mar);
        }
        public UsuarioRol ObtenerUsuarioRolIdBss(int id)
        {
            return dal.ObtenerUsuarioRolIdDal(id);
        }
        public void EditarUsuarioRolBss(UsuarioRol p)
        {
            dal.EditarUsuarioRolDal(p);
        }
        public void EliminarUsuarioRolBss(int id)
        {
            dal.EliminarUsuarioRolDal(id);
        }
        public DataTable UsuarioRolDatosBss()
        {
            return dal.UsuarioRolDatosDal();
        }
    }
}
