using AutomotrizBack.Servicio;
using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomotrizFront.ClienteH;
using Newtonsoft.Json;

namespace AutomotrizFront.Presentacion
{
    public partial class frmNuevoProducto : Form
    {
        private IServicio servicio;
        private Producto ProductoNvo;
        public frmNuevoProducto(FabricaServicioImp factory)
        {
            InitializeComponent();


            servicio = factory.CrearServicio();
            ProductoNvo = new Producto();
        }

        private async void frmNuevoProducto_Load(object sender, EventArgs e)
        {
            await CargarMarcas();
            await CargarTipoPro();
            await CargarTipoMat();
            await CargarPais();
            await CargarUnidPeso();
            await CargarUnidMedida();
        }

        private async Task CargarUnidMedida()
        {

            string url = "https://localhost:7063/api/Producto/UnidadMedidas";
            var result = await ClienteSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<UnidadMedida>>(result);
            cboUnidMed.DisplayMember = "descripcion";
            cboUnidMed.ValueMember = "id";
            cboUnidMed.DataSource = lst;
            cboUnidMed.SelectedIndex = -1;
            cboUnidMed.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task CargarUnidPeso()
        {
            string url = "https://localhost:7063/api/Producto/UnidadPeso";
            var result = await ClienteSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<UnidadPeso>>(result);
            cboUnidPes.DisplayMember = "descripcion";
            cboUnidPes.ValueMember = "id";
            cboUnidPes.DataSource = lst;
            cboUnidPes.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUnidPes.SelectedIndex = -1;
        }

        private async Task CargarPais()
        {
            string url = "https://localhost:7063/api/Producto/Pais";
            var result = await ClienteSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Pais>>(result);
            cboPais.DisplayMember = "pais";
            cboPais.ValueMember = "id_pais";
            cboPais.DataSource = lst;
            cboPais.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPais.SelectedIndex = -1;
        }

        private async Task CargarTipoMat()
        {
            string url = "https://localhost:7063/api/Producto/TipoMaterial";
            var result = await ClienteSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoMaterial>>(result);
            cboMaterial.DisplayMember = "descripcion";
            cboMaterial.ValueMember = "id";
            cboMaterial.DataSource = lst;
            cboMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPais.SelectedIndex = -1;
        }

        private async Task CargarTipoPro()
        {
            string url = "https://localhost:7063/api/Producto/TipoProducto";
            var result = await ClienteSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoProducto>>(result);
            cboTpProd.DisplayMember = "descripcion";
            cboTpProd.ValueMember = "id";
            cboTpProd.DataSource = lst;
            cboTpProd.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTpProd.SelectedIndex = -1;
        }

        private async Task CargarMarcas()
        {
            string url = "https://localhost:7063/api/Producto/Marcas";
            var result = await ClienteSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Marcas>>(result);
            cboMarca.DisplayMember = "marca";
            cboMarca.ValueMember = "id";
            cboMarca.DataSource = lst;
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTpProd.SelectedIndex = -1;
        }


        public void limpiar()
        {
            txtAlto.Text = string.Empty;
            txtAncho.Text = string.Empty;
            txtLargo.Text = string.Empty;   
            txtNum.Text = string.Empty;
            txtPrecio.Text = string.Empty; 
            txtVida.Text = string.Empty;
            cboMarca.SelectedIndex = -1;
            cboMaterial.SelectedIndex = -1;
            cboPais.SelectedIndex = -1;
            cboUnidMed.SelectedIndex = -1;
            cboUnidPes.SelectedIndex = -1; 
            cboMarca.SelectedIndex = -1;
            cboTpProd.SelectedIndex=-1;
            txtProducto.Text = string.Empty;
            txtPeso.Text = string.Empty;    
           
        }

        private async Task GrabarProducto()
        {
            try
            {
                string bodyContent = JsonConvert.SerializeObject(ProductoNvo);

                string url = "https://localhost:7063/api/Producto/nuevoProducto";
                var result = await ClienteSingleton.GetInstancia().PostAsync(url, bodyContent);

                if (result.Equals("Producto registrado", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Producto registrado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Producto NO registrado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_atras_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private async void btnGrabar_Click(object sender, EventArgs e)
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
            TipoMaterial material = (TipoMaterial)cboMaterial.SelectedItem;
            UnidadMedida unidadesMedida = (UnidadMedida)cboUnidMed.SelectedItem;
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

            ProductoNvo.Nombre = producto;
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

            await GrabarProducto();
           

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("El precio debe ir en formato numero", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtVida_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("La vida utildebe ir en formato numero", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("La vida util debe ir en formato numero", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
