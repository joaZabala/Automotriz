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

namespace AutomotrizFront.Presentacion.Producto
{
    public partial class frmConsultarProd : Form
    {
        IServicio servicio;
        List<ProductoAuto> producto;
        int id_producto = 0;

        public frmConsultarProd(FabricaServicioImp factory)
        {
            InitializeComponent();
            servicio = new Servicio();
            producto = new List<ProductoAuto>();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ConsultarProd_Load(object sender, EventArgs e)
        {
            CargarMarcas();
            CargarTipoPro();
            CargarTipoMat();
        }

        private void CargarTipoMat()
        {
            cboMaterial.DataSource = servicio.GetTipoMaterial();
            cboMaterial.DisplayMember = "descripcion";
            cboMaterial.ValueMember = "id";
        }

        private void CargarTipoPro()
        {
            cboTProducto.DataSource = servicio.GetTipoProductos();
            cboTProducto.DisplayMember = "descripcion";
            cboTProducto.ValueMember = "id";

        }

        private void CargarMarcas()
        {
            cboMarcas.DataSource = servicio.GetMarcas();
            cboMarcas.DisplayMember = "marca";
            cboMarcas.ValueMember = "id";
        }

        private IServicio GetServicio()
        {
            return servicio;
        }

        private void button1_Click(object sender, EventArgs e, IServicio servicio)
        {

        }




        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
        }



        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string producto = txtProducto.Text;
            TipoProducto tipoPro = (TipoProducto)cboTProducto.SelectedItem;
            Tipo_material tipoMat = (Tipo_material)cboMaterial.SelectedItem;
            Marcas marcas = (Marcas)cboMarcas.SelectedItem;


            int id_tipo_prod = tipoPro.Id;
            string tipo_producto = tipoPro.descripcion;
            int id_tipo_mat = tipoMat.id;
            string tipo_material = tipoMat.descripcion;
            int id_marca = marcas.id;
            string marca = marcas.marca;



            List<ProductoAuto> productos = servicio.GetProducParam(producto, id_tipo_prod, id_tipo_mat, id_marca);

            foreach (ProductoAuto p in productos)
            {
                dvgProductos.Rows.Add(new object[] { p.Id, p.Productos, tipo_producto, p.NumSerie, p.Precio, p.FechaFab, p.VidaUtil,
            p.Peso, p.IdUnidadPeso.Descripcion, p.Largo, p.Ancho, p.Alto,  p.IdUnidadMedida.descripcion, tipo_material, p.IdPais.pais, marca,"Editar" });
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombre = dvgProductos.CurrentRow.Cells[1].Value.ToString();
            int id = Convert.ToInt32(dvgProductos.CurrentRow.Cells[0].Value.ToString());

            if (MessageBox.Show("Esta seguro  que quiere borra para siempre el producto " +
                nombre + "?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (servicio.DeleteProducto(id))
                {
                    MessageBox.Show("Producto " + id + " borrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("no se pudo borrar el producto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string producto = dvgProductos.CurrentRow.Cells[1].Value.ToString();
            if (dvgProductos.CurrentCell.ColumnIndex == 16)
            {
                if (MessageBox.Show("Desea editar el producto " + "' " + producto + "'?", "Question",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id_producto = Convert.ToInt32(dvgProductos.CurrentRow.Cells[0].Value.ToString());

                    frmModificarProducto modificar = new frmModificarProducto(id_producto, new FabricaServicioImp());
                    modificar.ShowDialog();
                }
            }


        }
    }
}
