﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelo
{
    public class UsuarioRol
    {
        public int IdUsuarioRol { get; set; }
        public int IdUsuario {get; set; }
        public int IdRol { get; set; }
        public DateTime FechaAsig { get; set; }
        public string Estado { get; set; }

    }
}
