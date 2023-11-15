using AutomotrizBack.Datos.Implementacion;
using AutomotrizBack.Datos.Implementacion.Producto;
using AutomotrizBack.Entidades;
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

namespace AutomotrizFront.Presentacion
{
    public partial class frmNuevoProducto : Form
    {
        IServicio servicio;
        ProductoAuto ProductoNvo;
        public frmNuevoProducto(FabricaServicioImp factory)
        {
            InitializeComponent();


            servicio = factory.CrearServicio();
            ProductoNvo = new ProductoAuto();
        }

        private void frmNuevoProducto_Load(object sender, EventArgs e)
        {
            CargarMarcas();
            CargarTipoPro();
            CargarTipoMat();
            CargarPais();
            CargarUnidPeso();
            CargarUnidMedida();
        }

        private void CargarUnidMedida()
        {
            cboUnidMed.DataSource = servicio.GetUnidMedida();
            cboUnidMed.DisplayMember = "descripcion";
            cboUnidMed.ValueMember = "id";
        }

        private void CargarUnidPeso()
        {
            cboUnidPes.DataSource = servicio.GetUnidadPeso();
            cboUnidPes.DisplayMember = "descripcion";
            cboUnidPes.ValueMember = "id";
        }

        private void CargarPais()
        {
            cboPais.DataSource = servicio.GetPais();
            cboPais.DisplayMember = "pais";
            cboPais.ValueMember = "id_pais";
        }

        private void CargarTipoMat()
        {
            cboMaterial.DataSource = servicio.GetTipoMaterial();
            cboMaterial.DisplayMember = "descripcion";
            cboMaterial.ValueMember = "id";
        }

        private void CargarTipoPro()
        {
            cboTpProd.DataSource = servicio.GetTipoProductos();
            cboTpProd.DisplayMember = "descripcion";
            cboTpProd.ValueMember = "id";

        }

        private void CargarMarcas()
        {
            cboMarca.DataSource = servicio.GetMarcas();
            cboMarca.DisplayMember = "marca";
            cboMarca.ValueMember = "id";
        }

       

        
        private void GrabarProducto()
        {
            if (servicio.NuevoProducto(ProductoNvo) == true)
            {
                MessageBox.Show("Producto registrado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Producto NO registrado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAlto.Text) || string.IsNullOrEmpty(txtAncho.Text)
                || string.IsNullOrEmpty(txtLargo.Text) || string.IsNullOrEmpty(txtNum.Text) || string.IsNullOrEmpty(txtPeso.Text)
                    || string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(txtProducto.Text) || string.IsNullOrEmpty(txtVida.Text))
            {
                MessageBox.Show("Debe ingresar sus datos personales", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (cboMarca.SelectedIndex == -1 || cboMaterial.SelectedIndex == -1 || cboPais.SelectedIndex == -1 || cboTpProd.SelectedIndex == -1 || cboUnidMed.SelectedIndex == -1 ||
                    cboUnidPes.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar sus datos personales", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }




            TipoProducto TpProducto = (TipoProducto)cboTpProd.SelectedItem;
            Pais oPais = (Pais)cboPais.SelectedItem;
            Marcas marcas = (Marcas)cboMarca.SelectedItem;
            Tipo_material material = (Tipo_material)cboMaterial.SelectedItem;
            UnidadesMedida unidadesMedida = (UnidadesMedida)cboUnidMed.SelectedItem;
            UnidadPeso unidadPeso = (UnidadPeso)cboUnidPes.SelectedItem;
            string producto = txtProducto.Text;
            int NumSer = int.Parse(txtNum.Text);
            decimal Precio = decimal.Parse(txtPrecio.Text);
            decimal Alto = decimal.Parse(txtAlto.Text);
            decimal Ancho = decimal.Parse(txtAncho.Text);
            decimal Largo = decimal.Parse(txtLargo.Text);
            int vidaU = int.Parse(txtVida.Text);
            decimal Peso = decimal.Parse(txtPeso.Text);
            DateTime? fec_Fab = dtpFec_fab.Value;

            ProductoNvo.Productos = producto;
            ProductoNvo.Largo = Largo;
            ProductoNvo.FechaFab = fec_Fab;
            ProductoNvo.IdMarca = marcas;
            ProductoNvo.IdPais = oPais;
            ProductoNvo.IdTipoMaterial = material;
            ProductoNvo.IdTipoProducto = TpProducto;
            ProductoNvo.IdUnidadPeso = unidadPeso;
            ProductoNvo.Ancho = Ancho;
            ProductoNvo.NumSerie = NumSer;
            ProductoNvo.Precio = Precio;
            ProductoNvo.Alto = Alto;
            ProductoNvo.VidaUtil = vidaU;
            ProductoNvo.Peso = Peso;
            ProductoNvo.IdUnidadMedida = unidadesMedida;

            GrabarProducto();

        }
    }
}
