using SistemasVentas.BSS;
using SistemasVentas.VISTA.DetalleIngVista;
using SistemasVentas.VISTA.IngresoVista;
using System;
using SistemasVentas.VISTA.VentaVista;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ProveedorVistas
{
    public partial class ProveedorListarVista : Form
    {
        public ProveedorListarVista()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();
        private void ProveedorListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProveedorBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresoInsertarVista.IdProveedorSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            VentaInsertarVista.IdProveedorSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
