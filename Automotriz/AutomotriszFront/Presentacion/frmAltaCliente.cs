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

namespace AutomotriszFront.Presentacion
{
    public partial class frmAltaCliente : Form
    {
        IServicio Servicio;
        Cliente ClienteNvo;
        public frmAltaCliente(FabricaServicioImp factory)
        {
            InitializeComponent();
            Servicio = factory.CrearServicio();
            ClienteNvo = new Cliente();
        }

        private void frmAltaCliente_Load(object sender, EventArgs e)
        {
            CargarComboBarrio();
            CargarTiposCliente();
        }

        private void CargarTiposCliente()
        {
            cboTipo.DataSource = Servicio.GetTipoCliente();
            cboTipo.DisplayMember = "Tipo";
            cboTipo.ValueMember = "id";
        }

        public void CargarComboBarrio()
        {
            cboBarrio.DataSource = Servicio.GetBarrios();
            cboBarrio.DisplayMember = "Nombre";
            cboBarrio.ValueMember = "id_barrio";
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCuil.Text) || string.IsNullOrEmpty(txtNombre.Text)
                || string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Debe ingresar sus datos personales", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (cboBarrio.SelectedIndex == -1 || cboTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar sus datos personales", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }

            TipoCliente cliente = (TipoCliente)cboTipo.SelectedItem;
            barrio obarrio = (barrio)cboBarrio.SelectedItem;

            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string razon = txtRazonSocial.Text;
            string cuil = txtCuil.Text;

            ClienteNvo.RazonSocial = razon;
            ClienteNvo.Nombre = nombre;
            ClienteNvo.CuilCuit = cuil;
            ClienteNvo.Direccion = direccion;
            ClienteNvo.Barrio = obarrio;
            ClienteNvo.Tipo = cliente;

            dgvAltaClientes.Rows.Add(new object[] { nombre, obarrio.Nombre, direccion, razon, cuil, cliente.Tipo, "borrar" });
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvAltaClientes.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un cliente enla grilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GrabarCliente();
        }

        private void GrabarCliente()
        {
            if (Servicio.NuevoCliente(ClienteNvo) == true)
            {
                MessageBox.Show("Cliente registrado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cliente NO registrado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCuil.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtRazonSocial.Text = string.Empty;
            txtNombre.Text = string.Empty;
            dgvAltaClientes.Rows.Clear();
        }


        private void dgvAltaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAltaClientes.CurrentCell.ColumnIndex == 6)
            {
                dgvAltaClientes.Rows.RemoveAt(dgvAltaClientes.CurrentRow.Index);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("No se permiten caracteres especiales , ni numeros", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }

        private void txtCuil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("No se permiten letras , ni caracteres especiales", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }
    }
}
