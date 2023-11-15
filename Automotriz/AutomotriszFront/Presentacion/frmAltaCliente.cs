using AutomotrizBack.Entidades;
using AutomotrizBack.servicios;
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
            CargarTipoContacto();
            
        }

        private async void CargarTipoContacto()
        {
            string url = "https://localhost:7189/TipoContacto";
            var result = await ClienteSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoContacto>>(result);

            cboTipoContacto.DataSource = lst;
            cboTipoContacto.DisplayMember = "Descripcion";
            cboTipoContacto.ValueMember = "cod";
        }

       private async void CargarTiposCliente()
        {
            string url = "https://localhost:7189/TipoCliente";
            var result = await ClienteSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoCliente>>(result);

            cboTipo.DataSource = lst;
            cboTipo.DisplayMember = "Tipo";
            cboTipo.ValueMember = "Id";
        }



        public async void CargarComboBarrio()
        {
            string url = "https://localhost:7189/Barrio";
            var result = await ClienteSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<barrio>>(result);

            cboBarrio.DataSource = lst;
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
            TipoContacto Tcontac = (TipoContacto)cboTipoContacto.SelectedItem;

            Contacto c = new Contacto();
            c.Descripcion=txtContacto.Text;
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
            ClienteNvo.Barrio = obarrio;
            ClienteNvo.Tipo = cliente;

            dgvAltaClientes.Rows.Add(new object[] { nombre, obarrio.Nombre, direccion, razon, cuil, cliente.Tipo,c.Descripcion, "borrar" });
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

            string url = "https://localhost:7189/api/Cliente/nuevoCliente";
            var result = await ClienteSingleton.GetInstancia().PostAsync(url, bodyContent);

            if (result.Equals("Cliente registrado"))
            {
                MessageBox.Show("Cliente registrado ","Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                this.Dispose();
        }
    }
}
