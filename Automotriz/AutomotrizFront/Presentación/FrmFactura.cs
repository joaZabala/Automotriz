using AutomotrizBack.Datos;
using AutomotrizBack.Datos.Implementaciones;
using AutomotrizBack.Entidades;
using AutomotrizBack.Servicio;
using AutomotrizFront.ClienteH;
using Newtonsoft.Json;
using System;

namespace AutomotrizFront.Presentacion
{
    public partial class FrmFactura : Form
    {
        private Factura facturaNueva;

        public FrmFactura()
        {
            InitializeComponent();
            facturaNueva = new Factura();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Atrás?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private async void FrmFactura_Load(object sender, EventArgs e)
        {
            await CargarClientes();
            await CargarTiposFacturas();
            await CargarProductos();
            dgvDetalles.Rows.Clear();
        }

        private async Task CargarProductos()
        {
            string url = "https://localhost:7063/api/Factura/Productos";
            var result = await ClienteSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Producto>>(result);

            cboProducto.Items.Clear();
            cboProducto.ValueMember = "Id";
            cboProducto.DisplayMember = "Nombre";
            cboProducto.DataSource = lst;
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducto.SelectedIndex = -1;
        }

        private async Task CargarTiposFacturas()
        {
            cboTipoFactura.Items.Clear();

            string url = "https://localhost:7063/api/Factura/TiposFactura";
            var result = await ClienteSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoFactura>>(result);

            cboTipoFactura.ValueMember = "id";
            cboTipoFactura.DisplayMember = "descripcion";
            cboTipoFactura.DataSource = lst;
            cboTipoFactura.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoFactura.SelectedIndex = -1;
        }

        private async Task CargarClientes()
        {
            string url = "https://localhost:7063/api/Cliente/GetAll";
            var result = await ClienteSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Cliente>>(result);
            cboCliente.Items.Clear();
            List<Cliente> listaCliente = lst;
            cboCliente.ValueMember = "Cod";
            cboCliente.DisplayMember = "Nombre";
            cboCliente.DataSource = listaCliente;
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                Producto prod = (Producto)cboProducto.SelectedItem;
                DetalleFactura detalle = new DetalleFactura(prod, Convert.ToDecimal(txtPrecio.Text), (int)nudCantidad.Value);
                facturaNueva.AgregarDetalle(detalle);
                dgvDetalles.Rows.Add(new object[] { prod.Nombre, detalle.PrecioUnitario, nudCantidad.Value, "Quitar" });
            }

        }

        private bool Validaciones()
        {
            if (cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe elegir un Cliente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboTipoFactura.SelectedIndex == -1)
            {
                MessageBox.Show("Debe elegir un Tipo de Factura", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe elegir un Producto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPrecio.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe escribir un precio", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (nudCantidad.Value == 0)
            {
                MessageBox.Show("Elija una cantidad superior a cero", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.RowCount == 0)
            {
                MessageBox.Show("Debe agregar al menos un detalle", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Cliente cliente = (Cliente)cboCliente.SelectedItem;
                TipoFactura tipoFactura = (TipoFactura)cboTipoFactura.SelectedItem;
                facturaNueva.Cliente = cliente;
                facturaNueva.IdTipoFactura = tipoFactura.Id;
                facturaNueva.IdOrdenPedido = null;

                await ConfirmarFactura();
                LimpiarCampos();
            }

        }

        public async Task ConfirmarFactura()
        {
            string bodyContent = JsonConvert.SerializeObject(facturaNueva);
            string url = string.Format("https://localhost:7063/api/Factura/ConfirmarFactura");
            var result = await ClienteSingleton.GetInstancia().PostAsync(url, bodyContent);

            if (result.Equals("Factura registrada"))
            {
                MessageBox.Show("Factura Registrada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se registro la factura", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LimpiarCampos()
        {
            cboCliente.SelectedIndex = -1;
            cboTipoFactura.SelectedIndex = -1;
            cboProducto.SelectedIndex = -1;
            txtPrecio.Text = string.Empty;
            nudCantidad.Value = 0;
            dgvDetalles.Rows.Clear();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //if (HelperDB.GetInstancia().ConsultadeOrden((cboProducto.SelectedIndex + 1), (int)nudCantidad.Value) == 1)
            //{
            //    Producto prod = (Producto)cboProducto.SelectedItem;
            //    FrmOrden fOrden = new FrmOrden(prod, (int)nudCantidad.Value, Convert.ToDecimal(txtPrecio.Text));
            //    fOrden.Show(); // Muestra el formulario

            //    cboProducto.SelectedIndex = -1;
            //    txtPrecio.Text = "";
            //    nudCantidad.Value = 0;
            //}
        }

        private void grbDetalles_Enter(object sender, EventArgs e)
        {

        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 3)
            {
                facturaNueva.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.RemoveAt(dgvDetalles.CurrentRow.Index);
            }

        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvDetalles.Rows.Clear();
            cboCliente.SelectedIndex = -1;
            cboProducto.SelectedIndex = -1;
            cboTipoFactura.SelectedIndex = -1;
            txtPrecio.Text = string.Empty;
            nudCantidad.Value = 0;
        }
    }
}


