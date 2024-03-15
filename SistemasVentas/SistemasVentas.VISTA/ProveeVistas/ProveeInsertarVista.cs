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

namespace SistemasVentas.VISTA.ProveeVistas
{
    public partial class ProveeInsertarVista : Form
    {
        public ProveeInsertarVista()
        {
            InitializeComponent();
        }
        ProveeBss bss = new ProveeBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Provee ing = new Provee();
            ing.IdProducto  = Convert.ToInt32(textBox1.Text);
            ing.IdProveedor = Convert.ToInt32(textBox2.Text);
            ing.Fecha = dateTimePicker1.Value;
            ing.Precio = Convert.ToDecimal(textBox3.Text);
            bss.InsertarProveeBss(ing);
            MessageBox.Show("Recarga exitosa!");
        }

       
    }
}
