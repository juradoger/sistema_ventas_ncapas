using SistemasVentas.BSS;
using SistemasVentas.Modelo;
using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.PersonaVistas
{
    public partial class PersonaEditarVista : Form
    {
        int idx = 0;        
        Persona persona = new Persona();
        PersonaBss bssp = new PersonaBss();
        public PersonaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void PersonaEditarVista_Load(object sender, EventArgs e)
        {
            persona = bssp.ObtenerIdBss(idx);
            textBox1.Text = persona.Nombre;
            textBox2.Text = persona.Apellido; 
            textBox3.Text = persona.Telefono;
            textBox4.Text = persona.CI;
            textBox5.Text = persona.Correo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            persona.Nombre = textBox1.Text;
            persona.Apellido = textBox2.Text;
            persona.Telefono = textBox3.Text;   
            persona.CI = textBox4.Text;
            persona.Correo = textBox5.Text;
            bssp.EditarPersonaBss(persona);
            MessageBox.Show("Datos actualizados");

        }
    }
}
