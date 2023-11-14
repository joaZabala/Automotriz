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
    public partial class FrmModificarCliente : Form
    {
        IServicio servicio;
        Cliente cliente = null;
        public FrmModificarCliente(int codigo, FabricaServicioImp factory)
        {
            InitializeComponent();
            servicio = factory.CrearServicio();
            cliente = servicio.ClienteById(codigo);

        }
        private void FrmModificarCliente_Load(object sender, EventArgs e)
        {
            CargarTipos();
            CargarBarrios();
            CargarTipoContacto();
            txtCuil.Text = cliente.CuilCuit;
            txtNombre.Text = cliente.Nombre;
            txtRazonSocial.Text = cliente.RazonSocial.ToString();
            txtDireccion.Text = cliente.Direccion;
            cboBarrio.SelectedIndex = cliente.Barrio.id_barrio - 1;
            cboTipo.SelectedIndex = cliente.Tipo.Id - 1;
        }
        private void CargarTipoContacto()
        {
            cboTipoContacto.DataSource = servicio.tiposContac();
            cboTipoContacto.DisplayMember = "Descripcion";
            cboTipoContacto.ValueMember = "cod";
        }

        private void CargarBarrios()
        {
            cboBarrio.DataSource = servicio.GetBarrios();
            cboBarrio.ValueMember = "id_barrio";
            cboBarrio.DisplayMember = "Nombre";
        }

        private void CargarTipos()
        {
            cboTipo.DataSource = servicio.GetTipoCliente();
            cboTipo.ValueMember = "Id";
            cboTipo.DisplayMember = "Tipo";

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            TipoCliente c = (TipoCliente)cboTipo.SelectedItem;
            barrio b = (barrio)cboBarrio.SelectedItem;
            TipoContacto Tcontac = (TipoContacto)cboTipoContacto.SelectedItem;

            Contacto contac = new Contacto();
            contac.Descripcion = txtContacto.Text;
            contac.tipo_contacto = Tcontac;

            string nom = txtNombre.Text;
            int cod = cliente.Cod;
            string barrio = b.Nombre;
            string tipo = c.Tipo;
            string dirrec = txtDireccion.Text;
            string razon = txtRazonSocial.Text;
            string cuil = txtCuil.Text;

            cliente.Nombre = nom;
            cliente.Cod = cod;
            cliente.Barrio = b;
            cliente.Tipo = c;
            cliente.RazonSocial = razon;
            cliente.CuilCuit = cuil;
            cliente.Direccion = dirrec;
            cliente.AgregarContacto(contac);

            dgvAltaClientes.Rows.Add(new object[] {cod,nom,dirrec,
            razon,cuil,tipo,contac.Descripcion,"quitar"});
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (dgvAltaClientes.Rows.Count > 0)
            {
                if (servicio.editarCliente(cliente))
                {
                    MessageBox.Show("Cliente modificado", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("No se pudo modicar el cliente", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Dispose();
            }

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.ShowDialog();
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
