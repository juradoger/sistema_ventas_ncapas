using SistemasVentas.BSS;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.ClienteVista
{
    public partial class ClienteInsertarVista : Form
    {
        public ClienteInsertarVista()
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
        ClienteBss bssc = new ClienteBss();
        private void button1_Click_1(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.IdPersona = IdPersonaSeleccionada;
            cliente.TipoCliente = textBox2.Text;
            cliente.CodCliente = textBox3.Text;
            bssc.InsertarClienteBss(cliente);
            MessageBox.Show("Cliente registrado");
        }
    }
}
