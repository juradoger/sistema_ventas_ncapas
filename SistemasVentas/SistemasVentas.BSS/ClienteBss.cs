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
    public class ClienteBss
    {
        ClienteDal dal = new ClienteDal();
        public DataTable ListarClienteBss()
        {
            return dal.ListarClienteDal();
        }
        public void InsertarClienteBss(Cliente cliente)
        {
            dal.InsertarClienteDal(cliente);
        }
        public Cliente ObtenerIdCBss(int id)
        {
            return dal.ObtenerIdCDal(id);
        }
    }
   
}
