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
    public partial class MarcaInsertarVenta : Form
    {
        public MarcaInsertarVenta()
        {
            InitializeComponent();
        }
        MarcaBss bss = new MarcaBss();  
        private void button2_Click(object sender, EventArgs e)
        {
            Marca m = new Marca();
            m.Nombre = textBox1.Text;
            bss.InsertarMarcaBss(m);
            MessageBox.Show("Marca registrada!");
        }
    }
}
