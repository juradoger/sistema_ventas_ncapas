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

namespace SistemasVentas.VISTA.VentaVistas
{
    public partial class VentaInsertarVista : Form
    {
        public VentaInsertarVista()
        {
            InitializeComponent();
        }
        VentaBss bss = new VentaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Venta vet = new Venta();
            vet.IdCliente=Convert.ToInt32(textBox1.Text);
            vet.IdVendedor=Convert.ToInt32(textBox2.Text);
            vet.fecha = dateTimePicker1.Value;
            vet.Total=Convert.ToDecimal(textBox3.Text);
            vet.Estado = textBox4.Text;
            bss.InsertarVentaBss(vet);
            MessageBox.Show("Venta registrada!!");
        }

        private void VentaInsertarVista_Load(object sender, EventArgs e)
        {

        }
    }
}
