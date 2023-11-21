using AutomotrizBack.Entidades;
using AutomotrizBack.Servicio;
using AutomotrizFront.ClienteH;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizFront.Presentacion
{
    public partial class frmConsultarProd : Form
    {
        IServicio servicio;
        List<Producto> producto;

        public frmConsultarProd(FabricaServicioImp factory)
        {
            InitializeComponent();
            servicio = new Servicio();
            producto = new List<Producto>();


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

        private async void ConsultarProd_Load(object sender, EventArgs e)
        {
            await CargarMarcas();
            await CargarTipoPro();
            await CargarTipoMat();
        }

        private async Task CargarTipoMat()
        {
            string url = "https://localhost:7063/api/Producto/TipoMaterial";
            var result = await ClienteSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoMaterial>>(result);
            cboMaterial.DisplayMember = "descripcion";
            cboMaterial.ValueMember = "id";
            cboMaterial.DataSource = lst;
            cboMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMaterial.SelectedIndex = -1;
        }

        private async Task CargarTipoPro()
        {
            string url = "https://localhost:7063/api/Producto/TipoProducto";
            var result = await ClienteSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoProducto>>(result);
            cboTProducto.DisplayMember = "descripcion";
            cboTProducto.ValueMember = "id";
            cboTProducto.DataSource = lst;
            cboTProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTProducto.SelectedIndex = -1;
        }

        private async Task CargarMarcas()
        {
            string url = "https://localhost:7063/api/Producto/Marcas";
            var result = await ClienteSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Marcas>>(result);
            cboMarcas.DisplayMember = "marca";
            cboMarcas.ValueMember = "id";
            cboMarcas.DataSource = lst;
            cboMarcas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarcas.SelectedIndex = -1;

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
            this.Close();

        }

        private void eliminiar()
        {
            txtProducto.Text = string.Empty;
            cboMarcas.SelectedIndex = -1;
            cboTProducto.SelectedIndex = -1;
            cboMaterial.SelectedIndex = -1;
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProducto.Text) || cboMarcas.SelectedIndex == -1 || cboMaterial.SelectedIndex == -1 || cboTProducto.SelectedIndex == -1)
            {

                MessageBox.Show("Debe completar todos los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dvgProductos.Rows.Clear();
            string productos = txtProducto.Text;
            TipoProducto tpProd = (TipoProducto)cboTProducto.SelectedItem;
            int id_tipo_prod = Convert.ToInt32(tpProd.Id);
            TipoMaterial tpMat = (TipoMaterial)cboMaterial.SelectedItem;
            int id_tipo_mat = Convert.ToInt32(tpMat.Id);
            Marcas marcas = (Marcas)cboMarcas.SelectedItem;
            int id_marca = Convert.ToInt32(marcas.Id);

            string url = string.Format("https://localhost:7063/api/Producto/GetByFilters?Nombre={0}&tipoProducto={1}&material={2}&marca={3}",
                           //Uri.EscapeDataString(productos),
                           productos,
                           id_tipo_prod,
                           id_tipo_mat,
                           id_marca);
            var result = await ClienteSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Producto>>(result);

            producto = lst;


            foreach (Producto p in producto)
            {
                int rowIndex = dvgProductos.Rows.Add();
                dvgProductos.Rows[rowIndex].Cells["ID"].Value = p.Id;
                dvgProductos.Rows[rowIndex].Cells["Productos"].Value = p.Nombre;
                dvgProductos.Rows[rowIndex].Cells["Tipo_Producto"].Value = tpProd;
                dvgProductos.Rows[rowIndex].Cells["Num_Serie"].Value = p.NumSerie;
                dvgProductos.Rows[rowIndex].Cells["Precio"].Value = p.Precio;
                dvgProductos.Rows[rowIndex].Cells["fecha_fab"].Value = p.FechaFab;
                dvgProductos.Rows[rowIndex].Cells["Vida_util"].Value = p.VidaUtil;
                dvgProductos.Rows[rowIndex].Cells["Peso"].Value = p.Peso;

                dvgProductos.Rows[rowIndex].Cells["Largo"].Value = p.Largo;
                dvgProductos.Rows[rowIndex].Cells["Ancho"].Value = p.Ancho;
                dvgProductos.Rows[rowIndex].Cells["Alto"].Value = p.Alto;

                dvgProductos.Rows[rowIndex].Cells["tipodemateriales"].Value = tpMat;

                dvgProductos.Rows[rowIndex].Cells["marca"].Value = marcas;
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dvgProductos.SelectedRows.Count != 0)
            {
                string nombre = dvgProductos.CurrentRow.Cells[1].Value.ToString();
                int id = Convert.ToInt32(dvgProductos.CurrentRow.Cells[0].Value.ToString());

                string url = string.Format("https://localhost:7063/api/Producto/Delete?id={0}", id);
                var result = await ClienteSingleton.GetInstancia().DeleteAsync(url);

                if (MessageBox.Show("Esta seguro  que quiere borra para siempre el producto " +
                    nombre + "?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (result.Equals("producto eliminado correctamente"))
                    {

                        MessageBox.Show("Producto " + id + " borrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dvgProductos.Rows.Clear();
                        eliminiar();
                    }
                    else
                    {
                        MessageBox.Show("no se pudo borrar el producto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("debe selecccionar un producto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgProductos.CurrentCell.ColumnIndex == 15)
            {
                dvgProductos.Rows.RemoveAt(dvgProductos.CurrentRow.Index);
            }
        }
    }
}
