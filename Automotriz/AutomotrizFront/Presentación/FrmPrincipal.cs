using AutomotriszFront.Presentacion;
using AutomotrizBack.Servicio;
using AutomotrizFront.Presentacion;
using AutomotrizFront.Presentación;
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
                this.Close();
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

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta consulta = new frmConsulta(new FabricaServicioImp());
            consulta.ShowDialog();

        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNuevoProducto fNuevoProd = new frmNuevoProducto(new FabricaServicioImp());
            fNuevoProd.ShowDialog();

        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultarProd fConsultaProd = new frmConsultarProd(new FabricaServicioImp());
            fConsultaProd.ShowDialog();

        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFactura frmFactura = new FrmFactura();
            frmFactura.ShowDialog();

        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmConsultaFac fConFac = new FrmConsultaFac();
            fConFac.ShowDialog();

        }

        private void autoplanesPopularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAutoplanes fAuto = new FrmAutoplanes();
            fAuto.ShowDialog();

        }

        private void marcasPopularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarcasPopulares fMarcas = new MarcasPopulares();
            fMarcas.ShowDialog();

        }

        private void consultarTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarTotal frmConsultarTotal = new FrmConsultarTotal();
            frmConsultarTotal.ShowDialog();

        }

        private void piezasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_piezas fpiezas = new frm_piezas();
            fpiezas.ShowDialog();

        }

        private void mejoresClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMejorCliente fMejorCliente = new frmMejorCliente();
            fMejorCliente.ShowDialog();

        }

        private void nosotrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("405486 Dorado Arias Sofía Belén\r\n404931 Sagripanti Valentino\r\n405037 Toloza Lautaro Tomas\r\n404975 Zabala Joaquín Ariel\r\n405141 Ziade Manuel Alejandro", "INTEGRANTES");
        }
    }
}
