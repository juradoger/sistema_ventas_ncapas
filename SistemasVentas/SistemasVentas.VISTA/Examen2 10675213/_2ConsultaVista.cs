using SistemasVentas.BSS.Examen210675213BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.Examen2_10675213
{
    public partial class _2ConsultaVista : Form
    {
        public _2ConsultaVista()
        {
            InitializeComponent();
        }
        _2ConsultaBss bss = new _2ConsultaBss();
        private void _2ConsultaVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=bss.CalcularTotalIngresosPorProveedorBss();
        }
    }
}
