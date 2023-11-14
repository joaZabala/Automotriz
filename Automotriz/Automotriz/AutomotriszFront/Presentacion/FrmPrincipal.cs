﻿using AutomotriszFront.Presentacion;
using AutomotrizBack.servicios;
using AutomotrizFront.Presentacion;
using AutomotrizFront.Presentacion.Producto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizFront
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                this.Dispose();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaCliente nuevo = new frmAltaCliente(new FabricaServicioImp());
            nuevo.ShowDialog();
            this.Dispose();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta consulta = new frmConsulta(new FabricaServicioImp());
            consulta.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultarProd consultaProd = new frmConsultarProd(new FabricaServicioImp());
            consultaProd.ShowDialog();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNuevoProducto consultaProd = new frmNuevoProducto(new FabricaServicioImp());
            consultaProd.ShowDialog();
        }
    }
}
