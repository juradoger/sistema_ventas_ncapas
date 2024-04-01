using SistemasVentas.DAL.Examen210675213Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS.Examen210675213BSS
{
    public class _2ConsultaBss
    {
        _2ConsultaDal dal = new _2ConsultaDal();
        public DataTable CalcularTotalIngresosPorProveedorBss()
        {
            return dal.CalcularTotalIngresosPorVendedor();
        }
    }
}
