using AutomotrizFront.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomotrizBack.Entidades;

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

        private void reportePruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportePrueba frmReporte = new FrmReportePrueba();
            frmReporte.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }
    }
}
