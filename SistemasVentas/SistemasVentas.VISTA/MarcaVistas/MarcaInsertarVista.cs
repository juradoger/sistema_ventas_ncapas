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

namespace SistemasVentas.VISTA.MarcaVistas
{
    public partial class MarcaInsertarVista : Form
    {
        public MarcaInsertarVista()
        {
            InitializeComponent();
        }
        MarcaBss bss = new MarcaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Marca p = new Marca();
            p.Nombre = textBox1.Text;
            p.Estado = textBox2.Text;
            bss.InsertarMarcaBss(p);
            MessageBox.Show("Se guardó correctamente a Marca");
        }

        private void MarcaInsertarVista_Load(object sender, EventArgs e)
        {

        }
    }
}
