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

namespace SistemasVentas.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolInsertarVista : Form
    {
        public UsuarioRolInsertarVista()
        {
            InitializeComponent();
        }
        UsuarioRolBss bss = new UsuarioRolBss();
        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioRol r = new UsuarioRol();
            r.IdUsuario = Convert.ToInt32(textBox1.Text);
            r.IdRol = Convert.ToInt32(textBox2.Text);
            r.FechaAsig = dateTimePicker1.Value;
            bss.InsertarUsuarioRolBss(r);
            MessageBox.Show("Recarga exitosa!");


        }
    }
}
