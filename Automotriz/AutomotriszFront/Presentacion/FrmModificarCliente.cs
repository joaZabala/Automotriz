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
            txtCuil.Text = cliente.CuilCuit;
            txtNombre.Text = cliente.Nombre;
            txtRazonSocial.Text = cliente.RazonSocial.ToString();
            txtDireccion.Text = cliente.Direccion;
            cboBarrio.SelectedIndex = cliente.Barrio.id_barrio - 1;
            cboTipo.SelectedIndex = cliente.Tipo.Id - 1;
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

            string nom = txtNombre.Text;
            int cod = cliente.Cod;
            string barrio = b.Nombre;
            string tipo = c.Tipo;
            string dirrec = txtDireccion.Text;
            string razon = txtRazonSocial.Text;
            string cuil = txtCuil.Text;

            dgvAltaClientes.Rows.Add(new object[] {cod,nom,barrio, dirrec,
            razon,cuil,tipo,"quitar"});
        }
    }
}
