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
    public partial class _3ConsultaVista : Form
    {
        public _3ConsultaVista()
        {
            InitializeComponent();
        }
        _3ConsultaBss bss = new _3ConsultaBss();
        private void _3ConsultaVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.MarcaMasVendidaBss();
        }
    }
}
