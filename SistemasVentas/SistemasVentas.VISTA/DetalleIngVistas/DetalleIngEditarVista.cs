using SistemasVentas.BSS;
using SistemasVentas.Modelo;
using SistemasVentas.VISTA.IngresoVistas;
using SistemasVentas.VISTA.ProductoVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.DetalleIngVistas
{
    public partial class DetalleIngEditarVista : Form
    {
        int idx = 0;
        DetalleIng p = new DetalleIng();
        DetalleIngDalBss bss = new DetalleIngDalBss();
        public DetalleIngEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        public DetalleIngEditarVista()
        {
            InitializeComponent();
        }
        public static int IdProductoSeleccionada = 0;
        ProductoBss bsspro = new ProductoBss();
        private void button3_Click(object sender, EventArgs e)
        {
            ProductoListarVista fr = new ProductoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bsspro.ObtenerIdPBss(IdProductoSeleccionada);
                textBox1.Text = producto.Nombre;
            }
        }
        public static int IdIngresoSeleccionada = 0;
        IngresoBss bssing = new IngresoBss();
        private void button4_Click(object sender, EventArgs e)
        {
            IngresoListarVista fr = new IngresoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Ingreso ingreso = bssing.ObtenerIdBss(IdIngresoSeleccionada);
                textBox2.Text = ingreso.IdIngreso.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.IdIngreso = IdIngresoSeleccionada;
            p.IdProducto = IdProductoSeleccionada;
            p.FechaVenc = dateTimePicker1.Value;
            p.Cantidad = Convert.ToInt32(textBox4.Text);
            p.PrecioCosto = Convert.ToDecimal(textBox5.Text);
            p.PrecioVenta = Convert.ToDecimal(textBox6.Text);
            p.Subtotal = Convert.ToDecimal(textBox7.Text);

            bss.EditarDetalleIngBss(p);
            MessageBox.Show("Datos Actualizados");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DetalleIngEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerDetalleIngIdBss(idx);
            textBox1.Text = p.IdIngreso.ToString();
            textBox2.Text = p.IdProducto.ToString();
            dateTimePicker1.Value = p.FechaVenc;
            textBox4.Text = p.Cantidad.ToString();
            textBox5.Text = p.PrecioCosto.ToString();
            textBox6.Text = p.PrecioVenta.ToString();
            textBox7.Text = p.Subtotal.ToString();
        }
    }
}
