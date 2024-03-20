using SistemasVentas.BSS;
using SistemasVentas.Modelo;
using SistemasVentas.VISTA.VentaVistas;
using SistemasVentas.VISTA.TipoProdVistas;
using SistemasVentas.VISTA.MarcaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ProductoVista
{
    public partial class ProductoInsertarVista : Form
    {
        public ProductoInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdTipoProSeleccionada = 0;
        public static int IdMarcaSeleccionada = 0;
        MarcaBss bssm = new MarcaBss();
        private void button3_Click(object sender, EventArgs e)
        {
            MarcaListarVista fr = new MarcaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Marca marca = bssm.ObtenerIdBss(IdMarcaSeleccionada);
                textBox2.Text = marca.Nombre.ToString();

            }
        }
        TipoProdBss bss = new TipoProdBss();
        private void button2_Click(object sender, EventArgs e)
        {
            TipoProdListarVista fr = new TipoProdListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                TipoProducto tp = bss.ObtenerIdBss(IdTipoProSeleccionada);
                textBox1.Text = tp.Nombre.ToString();

            }
        }
        ProductoBss bsp = new ProductoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            prod.IdTipoProd = IdTipoProSeleccionada;
            prod.IdMarca = IdMarcaSeleccionada;
            prod.Nombre = textBox3.Text.ToString();
            prod.CodigoBarra = textBox4.Text.ToString();
            prod.Unidad = Convert.ToInt32(textBox5.Text);
            prod.Descripcion = textBox6.Text.ToString();
            bsp.InsertarProductoBss(prod);
            MessageBox.Show("Producto registrado");
        }
    }
}
