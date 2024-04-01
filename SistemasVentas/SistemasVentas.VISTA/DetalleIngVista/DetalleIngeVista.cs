using SistemasVentas.Modelo;
using SistemasVentas.VISTA.PersonaVistas;
using SistemasVentas.VISTA.IngresoVistas;
using SistemasVentas.VISTA.ProductoVistas;
using SistemasVentas.BSS;
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

namespace SistemasVentas.VISTA.DetalleIngVista
{
    public partial class DetalleIngeVista : Form
    {
        public DetalleIngeVista()
        {
            InitializeComponent();
        }
        public static int IdIngresoSeleccionada = 0;
        public static int IdProductoSeleccionada = 0;

        IngresoBss bss = new IngresoBss();
        private void button4_Click(object sender, EventArgs e)
        {
            IngresoListarVista fr = new IngresoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Ingreso ingreso = bss.ObtenerIdBss(IdIngresoSeleccionada);
                textBox1.Text=ingreso.IdIngreso.ToString();

            }
        }
        ProductoBss bssp = new ProductoBss();
        private void button3_Click(object sender, EventArgs e)
        {
            ProductoListarVista fr = new ProductoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
               // Producto producto = bssp.ObtenerIdPBss(IdProductoSeleccionada);
              //  textBox2.Text = producto.Nombre.ToString();

            }
        }
        DetalleIngDalBss bsp = new DetalleIngDalBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleIng detalle = new DetalleIng();
            detalle.IdIngreso = IdIngresoSeleccionada;
            detalle.IdProducto = IdProductoSeleccionada;
            detalle.FechaVenc = dateTimePicker1.Value;
            detalle.Cantidad = Convert.ToInt32(textBox4.Text);
            detalle.PrecioCosto = Convert.ToDecimal(textBox5.Text);
            detalle.PrecioVenta = Convert.ToDecimal(textBox6.Text);
            detalle.Subtotal = Convert.ToDecimal(textBox7.Text);
            bsp.InsertarDetalleIngBss(detalle);
            MessageBox.Show("Detalle registrado");
        }

        private void DetalleIngeVista_Load(object sender, EventArgs e)
        {

        }
    }
}
