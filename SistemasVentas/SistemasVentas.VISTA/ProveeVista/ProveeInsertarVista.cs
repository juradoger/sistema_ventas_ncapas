using SistemasVentas.BSS;
using SistemasVentas.Modelo;
using SistemasVentas.VISTA.ProductoVistas;
using SistemasVentas.VISTA.ProveedorVistas;
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

namespace SistemasVentas.VISTA.ProveeVista
{
    public partial class ProveeInsertarVista : Form
    {
        public ProveeInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdProveedorSeleccionada = 0;
        public static int IdProductoSeleccionada = 0;
        ProductoBss bssp = new ProductoBss();
        private void button3_Click(object sender, EventArgs e)
        {
            ProductoListarVista fr = new ProductoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                /*Producto producto = bssp.ObtenerIdPBss(IdProductoSeleccionada);
                textBox1.Text = producto.Nombre.ToString();*/

            }
        }
        ProveedorBss pbss = new ProveedorBss();
        private void button4_Click(object sender, EventArgs e)
        {
            ProveedorListarVista fr= new ProveedorListarVista();
            if(fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor proveedor = pbss.ObtenerIdProBss(IdProveedorSeleccionada);
                textBox2.Text = proveedor.Nombre.ToString();
            }
        }
        ProveeBss bsp = new ProveeBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Provee provee = new Provee();
            provee.IdProducto = IdProductoSeleccionada;
            provee.IdProveedor = IdProveedorSeleccionada;
            provee.Fecha = dateTimePicker1.Value;
            provee.Precio = Convert.ToDecimal(textBox3.Text);
            bsp.InsertarProveeBss(provee);
            MessageBox.Show("Registro registrado");
        }
    }
}
