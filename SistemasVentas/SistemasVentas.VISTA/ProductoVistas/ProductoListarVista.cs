using SistemasVentas.BSS;
using SistemasVentas.VISTA.DetalleIngVista;
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

namespace SistemasVentas.VISTA.ProductoVistas
{
    public partial class ProductoListarVista : Form
    {
        public ProductoListarVista()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();    
        private void ProductoListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProductoBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleIngeVista.IdProductoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleVentaInsertarVista.IdProductoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
