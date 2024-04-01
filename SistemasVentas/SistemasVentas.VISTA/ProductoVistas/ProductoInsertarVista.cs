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

namespace SistemasVentas.VISTA.ProductoVistas
{
    public partial class ProductoInsertarVista : Form
    {
        public ProductoInsertarVista()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();    
      /*  private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            /*Producto pro = new Producto();
            pro.IdTipoProd = Convert.ToInt32(textBox1.Text);
            pro.IdMarca = Convert.ToInt32(textBox2.Text);
            pro.Nombre =textBox3.Text;
            pro.CodigoBarra = textBox4.Text;
            pro.Unidad = Convert.ToInt32(textBox5.Text);
            pro.Descripcion=textBox6.Text;
            bss.InsertarProductoBss(pro);
            MessageBox.Show("Producto Registrado!");*/




        }
    }
}
