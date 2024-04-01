using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.DAL;
using SistemasVentas.DAL.Examen210675213Dal;

namespace SistemasVentas.BSS.Examen210675213BSS
{
    public class _1ConsultaBss
    {
        _1ConsultaDal dal = new _1ConsultaDal();
        public DataTable ListarClientesBss()
        {
            return dal.ListarClienteDal();
        }
    }
}
