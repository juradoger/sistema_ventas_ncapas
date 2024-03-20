using SistemasVentas.BSS;
using SistemasVentas.Modelo;
using SistemasVentas.VISTA.IngresoVistas;
using SistemasVentas.VISTA.ProductoVistas;
using SistemasVentas.VISTA.VentaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.DetalleVentaVista
{
    public partial class DetalleVentaInsertarVista : Form
    {
        public DetalleVentaInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdVentaSeleccionada = 0;
        public static int IdProductoSeleccionada = 0;
        VentaBss bss = new VentaBss();
        private void button4_Click(object sender, EventArgs e)
        {
            VentaListarVista fr = new VentaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Venta venta = bss.ObtenerIdBss(IdVentaSeleccionada);
                textBox1.Text = venta.IdVenta.ToString();

            }
        }
        ProductoBss bssp = new ProductoBss();

        private void button5_Click(object sender, EventArgs e)
        {
            ProductoListarVista fr = new ProductoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bssp.ObtenerIdPBss(IdProductoSeleccionada);
                textBox2.Text = producto.IdProducto.ToString();

            }
        }
        DetalleVentaBss bsp = new DetalleVentaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVenta detalle = new DetalleVenta();
            detalle.IdVenta = IdVentaSeleccionada;
            detalle.IdProducto = IdProductoSeleccionada;
            detalle.Cantidad = Convert.ToInt32(textBox3.Text);
            detalle.PrecioVenta = Convert.ToInt32(textBox4.Text);
            detalle.Subtotal = Convert.ToInt32(textBox5.Text);
            bsp.InsertarDetalleVentaBss(detalle);
            MessageBox.Show("Detalle registrado");
        }
    }
}
