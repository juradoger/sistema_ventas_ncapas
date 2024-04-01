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

namespace SistemasVentas.VISTA.ProveedorVistas
{
    public partial class ProveedorInsertarVista : Form
    {
        public ProveedorInsertarVista()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Proveedor prov = new Proveedor();
            prov.Nombre = textBox1.Text;
            prov.Telefono = textBox2.Text;
            prov.Direccion = textBox3.Text;
            prov.Estado= textBox4.Text;
            bss.InsertarProveedorBss(prov);
            MessageBox.Show("Exitoso!");
         
        }

        private void ProveedorInsertarVista_Load(object sender, EventArgs e)
        {

        }
    }
}
