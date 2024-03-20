using SistemasVentas.BSS;
using SistemasVentas.Modelo;
using SistemasVentas.VISTA.IngresoVistas;
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

namespace SistemasVentas.VISTA.IngresoVista
{
    public partial class IngresoInsertarVista : Form
    {
        public IngresoInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdProveedorSeleccionada = 0;
        ProveedorBss bss = new ProveedorBss();
        private void button3_Click(object sender, EventArgs e)
        {
            ProveedorListarVista fr = new ProveedorListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor proveedor = bss.ObtenerIdProBss(IdProveedorSeleccionada);
                textBox1.Text = proveedor.Nombre.ToString();

            }
        }
        IngresoBss bsp = new IngresoBss();
        private void button1_Click(object sender, EventArgs e)
        {

            Ingreso pro = new Ingreso();
            pro.IdProveedor = IdProveedorSeleccionada;
            pro.FechaIngreso = dateTimePicker1.Value;
            pro.Total = Convert.ToInt32(textBox2.Text);
         
            bsp.InsertarIngresoBss(pro);
            MessageBox.Show("Ingreso registrado");
        }
    }
}
