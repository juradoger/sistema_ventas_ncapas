﻿using SistemasVentas.BSS;
using SistemasVentas.VISTA.ProductoVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.TipoProdVistas
{
    public partial class TipoProdListarVista : Form
    {
        public TipoProdListarVista()
        {
            InitializeComponent();
        }
        TipoProdBss bss = new TipoProdBss(); 
        private void TipoProdListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarTipoProdBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductoInsertarVista.IdTipoProSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
