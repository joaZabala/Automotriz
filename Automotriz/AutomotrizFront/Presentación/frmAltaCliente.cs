using AutomotrizBack.Entidades;
using AutomotrizBack.Servicio;
using AutomotrizFront;
using AutomotrizFront.ClienteH;
using Newtonsoft.Json;
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

        Cliente ClienteNvo;

        public frmAltaCliente(FabricaServicioImp factory)
        {
            InitializeComponent();
            ClienteNvo = new Cliente();
        }

        private async void frmAltaCliente_Load(object sender, EventArgs e)
        {
            await CargarTipoContacto();
            await CargarTiposCliente();
            await CargarComboBarrio();

        }

        private async Task CargarTipoContacto()
        {
            string url = "https://localhost:7063/api/Cliente/TipoContacto";
            var result = await ClienteSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoContacto>>(result);
            cboTipoContacto.DataSource = lst;
            cboTipoContacto.ValueMember = "Cod";
            cboTipoContacto.DisplayMember = "Descripcion";
            //  cboTipoContacto.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task CargarTiposCliente()
        {

            string url = "https://localhost:7063/api/Cliente/TipoCliente";
            var result = await ClienteSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoCliente>>(result);
            cboTipo.DataSource = lst;
            cboTipo.ValueMember = "Id";
            cboTipo.DisplayMember = "Tipo";
        }

        public async Task CargarComboBarrio()
        {
            string url = "https://localhost:7063/api/Cliente/Barrio";
            var result = await ClienteSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Barrio>>(result);
            cboBarrio.DataSource = lst;
            cboBarrio.DisplayMember = "Nombre";
            cboBarrio.ValueMember = "IdBarrio";
            // cboBarrio.DropDownStyle = ComboBoxStyle.DropDownList;
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
            Barrio obarrio = (Barrio)cboBarrio.SelectedItem;
            TipoContacto Tcontac = (TipoContacto)cboTipoContacto.SelectedItem;

            Contacto c = new Contacto();
            c.Descripcion = txtContacto.Text;
            c.tipo_contacto = Tcontac;
            List<Contacto> lst = new List<Contacto>();

            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string razon = txtRazonSocial.Text;
            string cuil = txtCuil.Text;

            ClienteNvo.Contactos.Add(c);
            ClienteNvo.RazonSocial = razon;
            ClienteNvo.Nombre = nombre;
            ClienteNvo.CuilCuit = cuil;
            ClienteNvo.Direccion = direccion;
            ClienteNvo.IdBarrio = obarrio;
            ClienteNvo.IdTipoCliente = cliente;

            dgvAltaClientes.Rows.Add(new object[] { nombre, obarrio.Nombre, direccion, razon, cuil, cliente.Tipo, c.Descripcion, "borrar" });
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if (dgvAltaClientes.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un cliente enla grilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await GrabarCliente();

        }

        private async Task GrabarCliente()
        {
            string bodyContent = JsonConvert.SerializeObject(ClienteNvo);

            string url = "https://localhost:7063/api/Cliente/nuevoCliente";
            var result = await ClienteSingleton.GetInstancia().PostAsync(url, bodyContent);

            if (result.Equals("Cliente registrado"))
            {
                MessageBox.Show("Cliente registrado ", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCuil.Text = string.Empty;
                txtDireccion.Text = string.Empty;
                txtRazonSocial.Text = string.Empty;
                txtNombre.Text = string.Empty;
                dgvAltaClientes.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Cliente No registrado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dgvAltaClientes.CurrentCell.ColumnIndex == 7)
            {
                dgvAltaClientes.Rows.RemoveAt(dgvAltaClientes.CurrentRow.Index);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("No se permiten caracteres especiales , ni numeros", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }

        private void txtCuil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("No se permiten letras , ni caracteres especiales", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }

        private void dgvAltaClientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAltaClientes.CurrentCell.ColumnIndex == 7)
            {
                dgvAltaClientes.Rows.RemoveAt(dgvAltaClientes.CurrentRow.Index);

            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void cboTipoContacto_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cboBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtCuil_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtRazonSocial_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
        }

        private void cboBarrio_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void txtRazonSocial_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void txtContacto_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
        }

        private void cboTipoContacto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {

                MessageBox.Show("Escriba su nombre en formato correcto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }
    }
}
