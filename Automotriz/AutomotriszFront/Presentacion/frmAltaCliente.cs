using AutomotrizBack.servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotriszFront.Presentacion
{
    public partial class frmAltaCliente : Form
    {
        IServicio servicio;
        public frmAltaCliente(FabricaServicioImp factory)
        {
            InitializeComponent();
            servicio = factory.CrearServicio();
        }

        private void frmAltaCliente_Load(object sender, EventArgs e)
        {
            CargarComboBarrio();
            CargarTiposCliente();
        }

        private void CargarTiposCliente()
        {
            cboTipo.DataSource= servicio.GetTipoCliente();
            cboTipo.DisplayMember = "Tipo";
            cboTipo.ValueMember = "id";
        }

        public void CargarComboBarrio()
        {
            cboBarrio.DataSource = servicio.GetBarrios();
            cboBarrio.DisplayMember = "Nombre";
            cboBarrio.ValueMember = "id_barrio";
        }


    }
}
