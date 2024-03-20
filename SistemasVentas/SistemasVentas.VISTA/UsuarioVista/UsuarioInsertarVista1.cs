using SistemasVentas.Modelo;
using SistemasVentas.VISTA.PersonaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasVentas.BSS;
namespace SistemasVentas.VISTA.UsuarioVista


{ 
    public partial class UsuarioInsertarVista1 : Form
    {
        
        public UsuarioInsertarVista1()
        {
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bss = new PersonaBss();
        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bss.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
                                                             
            }
        }
        UsuarioBss bssuser = new UsuarioBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.IdPersona = IdPersonaSeleccionada;
            usuario.NombreUser = textBox2.Text;
            usuario.Contrasena = textBox4.Text;
            usuario.FechaReg = dateTimePicker1.Value;
            bssuser.InsertarUsuarioBss(usuario);
            MessageBox.Show("Usuario registrado");
        }
    }
}
