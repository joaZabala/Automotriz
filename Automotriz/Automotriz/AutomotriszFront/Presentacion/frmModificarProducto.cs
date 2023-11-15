using AutomotrizBack.Datos.Interfaz.Productos;
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
    public partial class frmModificarProducto : Form
    {
        public frmModificarProducto(int id_producto, FabricaServicioImp factory)
        {
            InitializeComponent();
            servicio = factory.CrearServicio();
            Producto = servicio.GetbyId(id_producto);
        }

        IServicio servicio;
        ProductoAuto Producto;

        private void frmModificarProducto_Load(object sender, EventArgs e)
        {


            CargarMarcas();
            CargarTipoPro();
            CargarTipoMat();
            CargarPais();
            CargarUnidPeso();
            CargarUnidMedida();
            txtProducto.Text = Producto.Productos.ToString();
            txtVida.Text = Producto.VidaUtil.ToString();
            txtPrecio.Text = Producto.Precio.ToString();
            txtPeso.Text = Producto.Peso.ToString();
            txtNum.Text = Producto.NumSerie.ToString();
            txtLargo.Text = Producto.Largo.ToString();
            txtAncho.Text = Producto.Ancho.ToString();
            txtAlto.Text = Producto.Alto.ToString();
            cboMarca.SelectedIndex = Producto.IdMarca.id - 1;
            cboMaterial.SelectedIndex = Producto.IdTipoMaterial.id - 1;
            cboPais.SelectedIndex = Producto.IdPais.id_pais - 1;
            cboTpProd.SelectedIndex = Producto.IdTipoProducto.Id - 1;
            cboUnidMed.SelectedIndex = Producto.IdUnidadMedida.id - 1;
            cboUnidPes.SelectedIndex = Producto.IdUnidadPeso.id - 1;

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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
        }




        

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            TipoProducto TpProducto = (TipoProducto)cboTpProd.SelectedItem;
            Pais oPais = (Pais)cboPais.SelectedItem;
            Marcas marcas = (Marcas)cboMarca.SelectedItem;
            Tipo_material material = (Tipo_material)cboMaterial.SelectedItem;
            UnidadesMedida unidadesMedida = (UnidadesMedida)cboUnidMed.SelectedItem;
            UnidadPeso unidadPeso = (UnidadPeso)cboUnidPes.SelectedItem;

            string productote = txtProducto.Text;
            int NumSer = int.Parse(txtNum.Text);
            decimal Precio = decimal.Parse(txtPrecio.Text);
            decimal Alto = decimal.Parse(txtAlto.Text);
            decimal Ancho = decimal.Parse(txtAncho.Text);
            decimal Largo = decimal.Parse(txtLargo.Text);
            int vidaU = int.Parse(txtVida.Text);
            decimal Peso = decimal.Parse(txtPeso.Text);
            DateTime? fec_Fab = dtpFec_fab.Value;


            Producto.Productos = productote;
            Producto.Largo = Largo;
            Producto.FechaFab = fec_Fab;
            Producto.IdMarca = marcas;
            Producto.IdPais = oPais;
            Producto.IdTipoMaterial = material;
            Producto.IdTipoProducto = TpProducto;
            Producto.IdUnidadPeso = unidadPeso;
            Producto.Ancho = Ancho;
            Producto.NumSerie = NumSer;
            Producto.Precio = Precio;
            Producto.Alto = Alto;
            Producto.VidaUtil = vidaU;
            Producto.Peso = Peso;
            Producto.IdUnidadMedida = unidadesMedida;

            dvgProductos.Rows.Add(new object[] {  productote, TpProducto, NumSer, Precio, fec_Fab, vidaU,
            Peso, unidadPeso, Largo,Ancho, Alto,  unidadesMedida, material, oPais, marcas,"Quitar"});

            if (dvgProductos.Rows.Count > 0)
            {
                if (servicio.ModificarProducto(Producto))
                {
                    MessageBox.Show("Producto modificado", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("No se pudo modicar el producto", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            }
        }
    }
}
