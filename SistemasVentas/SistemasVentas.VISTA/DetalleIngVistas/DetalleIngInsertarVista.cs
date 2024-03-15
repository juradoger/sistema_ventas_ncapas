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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.DetalleIngVistas
{
    public partial class DetalleIngInsertarVista : Form
    {
        public DetalleIngInsertarVista()
        {
            InitializeComponent();
        }
        DetalleIngDalBss bss = new DetalleIngDalBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleIng p = new DetalleIng();
            p.IdIngreso = Convert.ToInt32(textBox1.Text);
            p.IdProducto = Convert.ToInt32(textBox2.Text);
            p.FechaVenc = dateTimePicker1.Value;
            p.Cantidad = Convert.ToInt32(textBox4.Text);
            p.PrecioCosto = Convert.ToDecimal(textBox5.Text);
            p.PrecioVenta = Convert.ToDecimal(textBox6.Text);
            p.Subtotal = Convert.ToDecimal(textBox7.Text);

            bss.InsertarDetalleIngBss(p);

            MessageBox.Show("Registro Exitoso!");
        }
    }
}
