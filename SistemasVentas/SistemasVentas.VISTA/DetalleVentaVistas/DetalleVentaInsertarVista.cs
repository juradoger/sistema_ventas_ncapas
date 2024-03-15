using SistemasVentas.BSS;
using SistemasVentas.Modelo;
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
        DetalleVentaBss bss = new DetalleVentaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVenta v = new DetalleVenta();
            v.IdVenta = Convert.ToInt32(textBox1.Text);
            v.IdProducto = Convert.ToInt32(textBox2.Text);
            v.Cantidad = Convert.ToInt32(textBox3.Text);
            v.PrecioVenta = Convert.ToDecimal(textBox4.Text);
            v.Subtotal = Convert.ToDecimal(textBox5.Text);
            bss.InsertarDetalleVentaBss(v);
            MessageBox.Show("Registro Exitoso!");

        }
    }
}
