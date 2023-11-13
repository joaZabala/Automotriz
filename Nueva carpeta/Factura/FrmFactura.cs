using Factura.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura
{
    public partial class FrmFactura : Form
    {
        Factura facturaNueva;
        public FrmFactura()
        {
            InitializeComponent();
            facturaNueva = new Factura();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            CargarCombos();
            dgvDetalles.Rows.Clear();
        }

        private void CargarCombos()
        {
            //Combo Cliente:
            cboCliente.Items.Clear();
            //DataTable tablaClientes = HelperDB.GetInstancia().Consulta("SP_CONSULTAR_CLIENTES");
            List<Cliente> listaCliente = HelperDB.GetInstancia().ConsultarListaClientes();
            cboCliente.ValueMember = "cod_cliente";
            cboCliente.DisplayMember = "nombre";
            cboCliente.DataSource = listaCliente;
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.SelectedIndex = -1;

            //Combo Tipos Facturas:
            cboTipoFactura.Items.Clear();
            //DataTable tablaTipoFacturas = HelperDB.GetInstancia().Consulta("SP_CONSULTAR_TIPO_FACTURAS");
            List<TipoFactura> listaTFacturas = HelperDB.GetInstancia().ConsultarListaTFactura();
            cboTipoFactura.ValueMember = "id";
            cboTipoFactura.DisplayMember = "descripcion";
            cboTipoFactura.DataSource = listaTFacturas;
            cboTipoFactura.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoFactura.SelectedIndex = -1;

            //Combo Productos:
            cboProducto.Items.Clear();
            //DataTable tablaProductos = HelperDB.GetInstancia().Consulta("SP_CONSULTAR_PRODUCTOS");
            List<Producto> listaProd = HelperDB.GetInstancia().ConsultarListaProductos();
            cboProducto.ValueMember = "id_producto";
            cboProducto.DisplayMember = "producto";
            cboProducto.DataSource = listaProd;
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducto.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto prod = (Producto)cboProducto.SelectedItem;
            DetalleFactura detalle = new DetalleFactura(prod, Convert.ToDecimal(txtPrecio.Text), (int)nudCantidad.Value);
            facturaNueva.AgregarDetalle(detalle);
            dgvDetalles.Rows.Add(new object[] { prod.Nombre, txtPrecio.Text, nudCantidad.Value, "Quitar" });
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)cboCliente.SelectedItem;
            TipoFactura tipoFactura = (TipoFactura)cboTipoFactura.SelectedItem;
            facturaNueva.Cliente = cliente;
            facturaNueva.IdTipoFactura = tipoFactura.Id;
            facturaNueva.IdOrdenPedido = null;

            if (HelperDB.GetInstancia().Confirmar(facturaNueva))
            {
                MessageBox.Show("Factura guardada con éxito!");
            }
            else
            {
                MessageBox.Show("Ocurrió un error");
            }
        }
    }
}
