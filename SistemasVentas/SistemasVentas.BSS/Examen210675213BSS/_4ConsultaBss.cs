using SistemasVentas.DAL.Examen210675213Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS.Examen210675213BSS
{
    public class _4ConsultaBss
    {
        _4ConsultaDal dal = new _4ConsultaDal();
        public DataTable CantidadTotalPInventarioBss()
        {
            return dal.CantidadTotalProductoInventario();
        }
    }
}
