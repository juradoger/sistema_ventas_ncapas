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

namespace SistemasVentas.VISTA.IngresoVistas
{
    public partial class IngresoInsertarVista : Form
    {
        public IngresoInsertarVista()
        {
            InitializeComponent();
        }
        IngresoBss bss = new IngresoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Ingreso ing = new Ingreso();
            ing.IdProveedor = Convert.ToInt32(textBox1.Text);
            ing.FechaIngreso = dateTimePicker1.Value;
            ing.Total = Convert.ToDecimal(textBox2.Text);
            bss.InsertarIngresoBss(ing);
            MessageBox.Show("Recarga exitosa!");
        }
    }
}
