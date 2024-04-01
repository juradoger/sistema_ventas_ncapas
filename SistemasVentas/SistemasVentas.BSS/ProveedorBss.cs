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
    public class ProveedorBss
    {
        ProveedorDal dal = new ProveedorDal();
        public DataTable ListarProveedorBss()
        {
            return dal.ListarProveedorDal();
        }
        public void InsertarProveedorBss(Proveedor pre)
        {
            dal.InsertarProveedorDal(pre);
        }
        public Proveedor ObtenerIdProBss(int id)
        {
            return dal.ObtenerProveedorId(id);
        }
        public void EditarProveedorBss(Proveedor p)
        {
            dal.EditarProveedorDal(p);
        }
        public void EliminarProveedorBss(int id)
        {
            dal.EliminarProveedorDal(id);
        }
    }
    
}
