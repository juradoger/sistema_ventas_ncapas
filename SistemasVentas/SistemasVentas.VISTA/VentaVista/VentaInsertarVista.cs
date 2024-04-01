using SistemasVentas.BSS;
using SistemasVentas.Modelo;
using SistemasVentas.VISTA.PersonaVistas;
using SistemasVentas.VISTA.ClienteVistas;
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

namespace SistemasVentas.VISTA.VentaVista
{
    public partial class VentaInsertarVista : Form
    {
        public VentaInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdClienteSeleccionada = 0;
        public static int IdProveedorSeleccionada = 0;
        ClienteBss bssc = new ClienteBss();
        private void button3_Click(object sender, EventArgs e)
        {
            ClienteListarVista fr = new ClienteListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente persona = bssc.ObtenerIdCBss(IdClienteSeleccionada);
                textBox1.Text = persona.TipoCliente.ToString();

            }
        }
        ProveedorBss bssp = new ProveedorBss();
        private void button4_Click(object sender, EventArgs e)
        {
            ProveedorListarVista fr = new ProveedorListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor proveedor = bssp.ObtenerIdProBss(IdProveedorSeleccionada);
                textBox1.Text = proveedor.Nombre.ToString();

            }
        }
        VentaBss bssv = new VentaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta(); 
            venta.IdCliente=IdClienteSeleccionada;
            venta.IdVendedor = IdProveedorSeleccionada;
            venta.fecha = dateTimePicker1.Value;
            venta.Total = Convert.ToDecimal(textBox3.Text);
            venta.Estado = textBox4.Text;
            bssv.InsertarVentaBss(venta);
            MessageBox.Show("Venta registrada");
        }

        private void VentaInsertarVista_Load(object sender, EventArgs e)
        {

        }
    }
}
