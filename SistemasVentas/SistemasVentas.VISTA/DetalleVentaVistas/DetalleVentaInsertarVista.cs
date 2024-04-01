using SistemasVentas.BSS;
using SistemasVentas.Modelo;
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

namespace SistemasVentas.VISTA.DetalleVentaVistas
{
    public partial class DetalleVentaInsertarVista : Form
    {
        public DetalleVentaInsertarVista()
        {
            InitializeComponent();
        }

        public DetalleVentaInsertarVista(int idSeleccionada)
        {
            IdSeleccionada = idSeleccionada;
        }

        DetalleVentaBss bss = new DetalleVentaBss();

        public int IdSeleccionada { get; }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVenta p = new DetalleVenta();
            p.IdVenta = IdVentaSeleccionada;
            p.IdProducto = IdProductoSeleccionada;
            p.Cantidad = Convert.ToInt32(textBox3.Text);
            p.PrecioVenta = Convert.ToDecimal(textBox4.Text);
            p.Subtotal = Convert.ToDecimal(textBox5.Text);
            bss.InsertarDetalleVentaBss(p);
            MessageBox.Show("Se guardó correctamente");

        }

        private void DetalleVentaInsertarVista_Load(object sender, EventArgs e)
        {

        }
        public static int IdProductoSeleccionada = 0;
        ProductoBss bsspro = new ProductoBss();

        private void button4_Click(object sender, EventArgs e)
        {
            ProductoListarVista fr = new ProductoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bsspro.ObtenerIdPBss(IdProductoSeleccionada);
                textBox2.Text = producto.Nombre;
            }
        }
        public static int IdVentaSeleccionada = 0;
        VentaBss bssven = new VentaBss();
        private void button3_Click(object sender, EventArgs e)
        {
            VentaListarVista fr = new VentaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Venta venta = bssven.ObtenerIdBss(IdVentaSeleccionada);
                textBox1.Text = venta.IdVenta.ToString();
            }
        }
    }
}
