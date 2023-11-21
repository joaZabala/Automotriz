using AutomotrizBack.Datos.Implementaciones;
using AutomotrizBack.Entidades;
using AutomotrizBack.Servicio;
using AutomotrizFront.ClienteH;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizFront.Presentacion
{
    public partial class FrmModificarCliente : Form
    {

        int Codigo;
        Cliente Cliente;
        public FrmModificarCliente(int codigo, FabricaServicioImp factory)
        {
            InitializeComponent();
            Codigo = codigo;
            Cliente = new Cliente();

        }


        private async void FrmModificarCliente_Load(object sender, EventArgs e)
        {
            await CargarTipoContacto();
            await CargarTipos();
            await CargarBarrios();
            await CargarCliente();

        }

        private async Task CargarCliente()
        {
            try
            {
                string url = string.Format("https://localhost:7063/api/Cliente/GetClientetById?cod_cliente={0}", Codigo);
                var result = await ClienteSingleton.GetInstancia().GetAsync(url);
                var cliente = JsonConvert.DeserializeObject<Cliente>(result);

                if (cliente != null)
                {
                    txtNombre.Text = cliente.Nombre;
                    txtRazonSocial.Text = cliente.RazonSocial;
                    txtDireccion.Text = cliente.Direccion;
                    txtCuil.Text = cliente.CuilCuit;
                    cboBarrio.SelectedValue = cliente.IdBarrio.IdBarrio;
                    cboTipo.SelectedValue = cliente.IdTipoCliente.Id;
                }
                else
                {
                    MessageBox.Show("El cliente es nulo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar cliente: {ex.Message}");
            }
        }
        private async Task CargarTipoContacto()
        {
            string url = "https://localhost:7063/api/Cliente/TipoContacto";
            var result = await ClienteSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoContacto>>(result);
            cboTipoContacto.DataSource = lst;
            cboTipoContacto.ValueMember = "Cod";
            cboTipoContacto.DisplayMember = "Descripcion";

        }

        private async Task CargarBarrios()
        {
            string url = "https://localhost:7063/api/Cliente/Barrio";
            var result = await ClienteSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Barrio>>(result);
            cboBarrio.DataSource = lst;
            cboBarrio.ValueMember = "IdBarrio";
            cboBarrio.DisplayMember = "Nombre";
        }

        private async Task CargarTipos()
        {
            string url = "https://localhost:7063/api/Cliente/TipoCliente";
            var result = await ClienteSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoCliente>>(result);
            cboTipo.DataSource = lst;
            cboTipo.ValueMember = "Id";
            cboTipo.DisplayMember = "Tipo";
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            TipoCliente c = (TipoCliente)cboTipo.SelectedItem;
            Barrio b = (Barrio)cboBarrio.SelectedItem;
            TipoContacto Tcontac = (TipoContacto)cboTipoContacto.SelectedItem;

            Contacto contac = new Contacto();
            contac.Descripcion = txtContacto.Text;
            contac.tipo_contacto = Tcontac;

            string nom = txtNombre.Text;
            int cod = Codigo;
            string barrio = b.Nombre;
            string tipo = c.Tipo;
            string dirrec = txtDireccion.Text;
            string razon = txtRazonSocial.Text;
            string cuil = txtCuil.Text;

            Cliente.Nombre = nom;
            Cliente.Cod = cod;
            Cliente.IdBarrio = b;
            Cliente.IdTipoCliente = c;
            Cliente.RazonSocial = razon;
            Cliente.CuilCuit = cuil;
            Cliente.Direccion = dirrec;
            Cliente.AgregarContacto(contac);

            dgvAltaClientes.Rows.Add(new object[] {cod,nom,dirrec,
            razon,cuil,tipo,contac.Descripcion,"quitar"});
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvAltaClientes.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un cliente enla grilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            await ModificarCliente();
        }

        private async Task ModificarCliente()
        {
            string bodyContent = JsonConvert.SerializeObject(Cliente);
            string url = "https://localhost:7063/api/Cliente/modificacion";
            var result = await ClienteSingleton.GetInstancia().PutAsync(url, bodyContent);

            if (result.Equals("cliente modificado"))
            {
                MessageBox.Show("Cliente modificado", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo modificar el cliente", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        public void Limpiar()
        {
            txtCuil.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtRazonSocial.Text = string.Empty;
            cboBarrio.SelectedIndex = -1;
            cboTipo.SelectedIndex = -1;
            dgvAltaClientes.Rows.Clear();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvAltaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAltaClientes.CurrentCell.ColumnIndex == 7)
            {
                dgvAltaClientes.Rows.RemoveAt(dgvAltaClientes.CurrentRow.Index);
            }
        }
    }
}
