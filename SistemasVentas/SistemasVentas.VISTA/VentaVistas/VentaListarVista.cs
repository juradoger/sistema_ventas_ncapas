using SistemasVentas.BSS;
using SistemasVentas.VISTA.DetalleVentaVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.VentaVistas
{
    public partial class VentaListarVista : Form
    {
        public VentaListarVista()
        {
            InitializeComponent();
        }
        VentaBss bss = new VentaBss();
        private void ListarVentaVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarVentaBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVentaInsertarVista.IdVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
