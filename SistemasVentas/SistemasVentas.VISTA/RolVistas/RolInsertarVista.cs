﻿using SistemasVentas.BSS;
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

namespace SistemasVentas.VISTA.RolVistas
{
    public partial class RolInsertarVista : Form
    {
        public RolInsertarVista()
        {
            InitializeComponent();
        }
        RolBss bss = new RolBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Rol r = new Rol();
            r.Nombre = textBox1.Text;
            r.Estado = textBox2.Text;
            bss.InsertarRolBss(r);
            MessageBox.Show("Exito!");
        }

        private void RolInsertarVista_Load(object sender, EventArgs e)
        {

        }
    }
}
