using SistemasVentas.DAL.Examen210675213Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS.Examen210675213BSS
{
    public class _5ConsultaBss
    {
        _5ConsultaDal dal = new _5ConsultaDal();
        public DataTable ProductoProxExpirarBss()
        {
            return dal.ProductoProxExpirar();
        }
    }
}
