using SistemasVentas.DAL;
using SistemasVentas.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class TipoProdBss
    {
        TipoProdDal dal = new TipoProdDal();
        public DataTable ListarTipoProdBss()
        {
            return dal.ListarTipoProdDal();
        }
        public void InsertarTipoProdBss(TipoProducto mar)
        {
            dal.InsertarTipoProdDal(mar);
        }
        public TipoProducto ObtenerIdBss(int id)
        {
            return dal.ObtenerIdDal(id);
        }
        public void EditarTipoProdBss(TipoProducto p)
        {
            dal.EditarTipoProdDal(p);
        }
        public void EliminarTipoProdBss(int id)
        {
            dal.EliminarTipoProdDal(id);
        }

    }
}
