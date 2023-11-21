using System;
using System.Windows.Forms;
using AutomotrizBack.Entidades;


namespace AutomotrizFront.Presentacion
{
    partial class frmConsultarProd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtProducto = new TextBox();
            cboMarcas = new ComboBox();
            cboMaterial = new ComboBox();
            cboTProducto = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAtras = new Button();
            btnConsultar = new Button();
            btnEliminar = new Button();
            dvgProductos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Productos = new DataGridViewTextBoxColumn();
            Tipo_Producto = new DataGridViewTextBoxColumn();
            Num_Serie = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            fecha_fab = new DataGridViewTextBoxColumn();
            Vida_util = new DataGridViewTextBoxColumn();
            Peso = new DataGridViewTextBoxColumn();
            Largo = new DataGridViewTextBoxColumn();
            Ancho = new DataGridViewTextBoxColumn();
            Alto = new DataGridViewTextBoxColumn();
            tipodemateriales = new DataGridViewTextBoxColumn();
            marca = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dvgProductos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(431, 28);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(486, 22);
            label3.Name = "label3";
            label3.Size = new Size(135, 29);
            label3.TabIndex = 19;
            label3.Text = "Productos ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(109, 98);
            label2.Name = "label2";
            label2.Size = new Size(79, 18);
            label2.TabIndex = 21;
            label2.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(210, 95);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(247, 23);
            txtProducto.TabIndex = 22;
            // 
            // cboMarcas
            // 
            cboMarcas.FormattingEnabled = true;
            cboMarcas.Location = new Point(610, 95);
            cboMarcas.Name = "cboMarcas";
            cboMarcas.Size = new Size(146, 23);
            cboMarcas.TabIndex = 23;
            // 
            // cboMaterial
            // 
            cboMaterial.FormattingEnabled = true;
            cboMaterial.Location = new Point(610, 152);
            cboMaterial.Name = "cboMaterial";
            cboMaterial.Size = new Size(146, 23);
            cboMaterial.TabIndex = 24;
            // 
            // cboTProducto
            // 
            cboTProducto.FormattingEnabled = true;
            cboTProducto.Location = new Point(210, 149);
            cboTProducto.Name = "cboTProducto";
            cboTProducto.Size = new Size(247, 23);
            cboTProducto.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(58, 151);
            label4.Name = "label4";
            label4.Size = new Size(139, 18);
            label4.TabIndex = 26;
            label4.Text = "Tipo de producto";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(537, 98);
            label5.Name = "label5";
            label5.Size = new Size(57, 18);
            label5.TabIndex = 27;
            label5.Text = "Marca";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(521, 154);
            label6.Name = "label6";
            label6.Size = new Size(73, 18);
            label6.TabIndex = 28;
            label6.Text = "Material";
            // 
            // btnAtras
            // 
            btnAtras.ForeColor = SystemColors.ActiveCaptionText;
            btnAtras.Location = new Point(29, 415);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 31;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.ForeColor = SystemColors.ActiveCaptionText;
            btnConsultar.Location = new Point(861, 86);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 32);
            btnConsultar.TabIndex = 32;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminar.Location = new Point(861, 143);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 32);
            btnEliminar.TabIndex = 33;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dvgProductos
            // 
            dvgProductos.AllowUserToAddRows = false;
            dvgProductos.AllowUserToDeleteRows = false;
            dvgProductos.BackgroundColor = Color.FromArgb(101, 14, 2);
            dvgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProductos.Columns.AddRange(new DataGridViewColumn[] { ID, Productos, Tipo_Producto, Num_Serie, Precio, fecha_fab, Vida_util, Peso, Largo, Ancho, Alto, tipodemateriales, marca });
            dvgProductos.Location = new Point(10, 194);
            dvgProductos.Name = "dvgProductos";
            dvgProductos.ReadOnly = true;
            dvgProductos.RowHeadersWidth = 51;
            dvgProductos.RowTemplate.Height = 25;
            dvgProductos.Size = new Size(1027, 183);
            dvgProductos.TabIndex = 34;
            dvgProductos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 125;
            // 
            // Productos
            // 
            Productos.HeaderText = "Producto";
            Productos.MinimumWidth = 6;
            Productos.Name = "Productos";
            Productos.ReadOnly = true;
            Productos.Width = 125;
            // 
            // Tipo_Producto
            // 
            Tipo_Producto.HeaderText = "Tipo de producto";
            Tipo_Producto.MinimumWidth = 6;
            Tipo_Producto.Name = "Tipo_Producto";
            Tipo_Producto.ReadOnly = true;
            Tipo_Producto.Width = 125;
            // 
            // Num_Serie
            // 
            Num_Serie.HeaderText = "Numero serie";
            Num_Serie.MinimumWidth = 6;
            Num_Serie.Name = "Num_Serie";
            Num_Serie.ReadOnly = true;
            Num_Serie.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 125;
            // 
            // fecha_fab
            // 
            fecha_fab.HeaderText = "fecha de fabricacion";
            fecha_fab.MinimumWidth = 6;
            fecha_fab.Name = "fecha_fab";
            fecha_fab.ReadOnly = true;
            fecha_fab.Width = 125;
            // 
            // Vida_util
            // 
            Vida_util.HeaderText = "Vida Util";
            Vida_util.MinimumWidth = 6;
            Vida_util.Name = "Vida_util";
            Vida_util.ReadOnly = true;
            Vida_util.Width = 125;
            // 
            // Peso
            // 
            Peso.HeaderText = "Peso";
            Peso.MinimumWidth = 6;
            Peso.Name = "Peso";
            Peso.ReadOnly = true;
            Peso.Width = 125;
            // 
            // Largo
            // 
            Largo.HeaderText = "Largo";
            Largo.MinimumWidth = 6;
            Largo.Name = "Largo";
            Largo.ReadOnly = true;
            Largo.Width = 125;
            // 
            // Ancho
            // 
            Ancho.HeaderText = "Ancho";
            Ancho.MinimumWidth = 6;
            Ancho.Name = "Ancho";
            Ancho.ReadOnly = true;
            Ancho.Width = 125;
            // 
            // Alto
            // 
            Alto.HeaderText = "Alto";
            Alto.MinimumWidth = 6;
            Alto.Name = "Alto";
            Alto.ReadOnly = true;
            Alto.Width = 125;
            // 
            // tipodemateriales
            // 
            tipodemateriales.HeaderText = "Tipo de Material";
            tipodemateriales.MinimumWidth = 6;
            tipodemateriales.Name = "tipodemateriales";
            tipodemateriales.ReadOnly = true;
            tipodemateriales.Width = 125;
            // 
            // marca
            // 
            marca.HeaderText = "Marca";
            marca.MinimumWidth = 6;
            marca.Name = "marca";
            marca.ReadOnly = true;
            marca.Width = 125;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(1, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1053, 78);
            panel1.TabIndex = 35;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Diseño_sin_título;
            pictureBox1.Location = new Point(28, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 68;
            pictureBox1.TabStop = false;
            // 
            // frmConsultarProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(101, 14, 2);
            ClientSize = new Size(1053, 453);
            Controls.Add(panel1);
            Controls.Add(dvgProductos);
            Controls.Add(btnEliminar);
            Controls.Add(btnConsultar);
            Controls.Add(btnAtras);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cboTProducto);
            Controls.Add(cboMaterial);
            Controls.Add(cboMarcas);
            Controls.Add(txtProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmConsultarProd";
            Text = "ConsultarProd";
            Load += ConsultarProd_Load;
            ((System.ComponentModel.ISupportInitialize)dvgProductos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtProducto;
        private ComboBox cboMarcas;
        private ComboBox cboMaterial;
        private ComboBox cboTProducto;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAtras;
        private Button btnConsultar;
        private Button btnEliminar;

        private DataGridView dvgProductos;
        private DataGridViewTextBoxColumn Quitar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Productos;
        private DataGridViewTextBoxColumn Tipo_Producto;
        private DataGridViewTextBoxColumn Num_Serie;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn fecha_fab;
        private DataGridViewTextBoxColumn Vida_util;
        private DataGridViewTextBoxColumn Peso;
        private DataGridViewTextBoxColumn Largo;
        private DataGridViewTextBoxColumn Ancho;
        private DataGridViewTextBoxColumn Alto;
        private DataGridViewTextBoxColumn tipodemateriales;
        private DataGridViewTextBoxColumn marca;
    }
}