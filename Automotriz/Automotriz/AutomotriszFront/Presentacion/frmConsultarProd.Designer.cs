namespace AutomotrizFront.Presentacion.Producto
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
            Unidad_peso = new DataGridViewTextBoxColumn();
            Largo = new DataGridViewTextBoxColumn();
            Ancho = new DataGridViewTextBoxColumn();
            Alto = new DataGridViewTextBoxColumn();
            IdUnidadMedida = new DataGridViewTextBoxColumn();
            tipodemateriales = new DataGridViewTextBoxColumn();
            IdPais = new DataGridViewTextBoxColumn();
            marca = new DataGridViewTextBoxColumn();
            Acciones = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dvgProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(385, 26);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(407, 19);
            label3.Name = "label3";
            label3.Size = new Size(112, 26);
            label3.TabIndex = 19;
            label3.Text = "Productos ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 72);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 21;
            label2.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(138, 69);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(247, 23);
            txtProducto.TabIndex = 22;
            // 
            // cboMarcas
            // 
            cboMarcas.FormattingEnabled = true;
            cboMarcas.Location = new Point(538, 69);
            cboMarcas.Name = "cboMarcas";
            cboMarcas.Size = new Size(146, 23);
            cboMarcas.TabIndex = 23;
            // 
            // cboMaterial
            // 
            cboMaterial.FormattingEnabled = true;
            cboMaterial.Location = new Point(538, 126);
            cboMaterial.Name = "cboMaterial";
            cboMaterial.Size = new Size(146, 23);
            cboMaterial.TabIndex = 24;
            // 
            // cboTProducto
            // 
            cboTProducto.FormattingEnabled = true;
            cboTProducto.Location = new Point(191, 123);
            cboTProducto.Name = "cboTProducto";
            cboTProducto.Size = new Size(169, 23);
            cboTProducto.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 129);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 26;
            label4.Text = "Tipo de producto";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(479, 72);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 27;
            label5.Text = "Marca";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(469, 131);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 28;
            label6.Text = "Material";
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(685, 415);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 31;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(789, 55);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 32);
            btnConsultar.TabIndex = 32;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(789, 126);
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
            dvgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProductos.Columns.AddRange(new DataGridViewColumn[] { ID, Productos, Tipo_Producto, Num_Serie, Precio, fecha_fab, Vida_util, Peso, Unidad_peso, Largo, Ancho, Alto, IdUnidadMedida, tipodemateriales, IdPais, marca, Acciones });
            dvgProductos.Location = new Point(60, 191);
            dvgProductos.Name = "dvgProductos";
            dvgProductos.ReadOnly = true;
            dvgProductos.RowTemplate.Height = 25;
            dvgProductos.Size = new Size(818, 183);
            dvgProductos.TabIndex = 34;
            dvgProductos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Productos
            // 
            Productos.HeaderText = "Producto";
            Productos.Name = "Productos";
            Productos.ReadOnly = true;
            // 
            // Tipo_Producto
            // 
            Tipo_Producto.HeaderText = "Tipo de producto";
            Tipo_Producto.Name = "Tipo_Producto";
            Tipo_Producto.ReadOnly = true;
            // 
            // Num_Serie
            // 
            Num_Serie.HeaderText = "Numero serie";
            Num_Serie.Name = "Num_Serie";
            Num_Serie.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // fecha_fab
            // 
            fecha_fab.HeaderText = "fecha de fabricacion";
            fecha_fab.Name = "fecha_fab";
            fecha_fab.ReadOnly = true;
            // 
            // Vida_util
            // 
            Vida_util.HeaderText = "Vida Util";
            Vida_util.Name = "Vida_util";
            Vida_util.ReadOnly = true;
            // 
            // Peso
            // 
            Peso.HeaderText = "Peso";
            Peso.Name = "Peso";
            Peso.ReadOnly = true;
            // 
            // Unidad_peso
            // 
            Unidad_peso.HeaderText = "Unidad de peso";
            Unidad_peso.Name = "Unidad_peso";
            Unidad_peso.ReadOnly = true;
            // 
            // Largo
            // 
            Largo.HeaderText = "Largo";
            Largo.Name = "Largo";
            Largo.ReadOnly = true;
            // 
            // Ancho
            // 
            Ancho.HeaderText = "Ancho";
            Ancho.Name = "Ancho";
            Ancho.ReadOnly = true;
            // 
            // Alto
            // 
            Alto.HeaderText = "Alto";
            Alto.Name = "Alto";
            Alto.ReadOnly = true;
            // 
            // IdUnidadMedida
            // 
            IdUnidadMedida.HeaderText = "Unidad de medida";
            IdUnidadMedida.Name = "IdUnidadMedida";
            IdUnidadMedida.ReadOnly = true;
            // 
            // tipodemateriales
            // 
            tipodemateriales.HeaderText = "Tipo de Material";
            tipodemateriales.Name = "tipodemateriales";
            tipodemateriales.ReadOnly = true;
            // 
            // IdPais
            // 
            IdPais.HeaderText = "Pais";
            IdPais.Name = "IdPais";
            IdPais.ReadOnly = true;
            // 
            // marca
            // 
            marca.HeaderText = "Marca";
            marca.Name = "marca";
            marca.ReadOnly = true;
            // 
            // Acciones
            // 
            Acciones.HeaderText = "Column1";
            Acciones.Name = "Acciones";
            Acciones.ReadOnly = true;
            // 
            // frmConsultarProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 450);
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
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmConsultarProd";
            Text = "ConsultarProd";
            Load += ConsultarProd_Load;
            ((System.ComponentModel.ISupportInitialize)dvgProductos).EndInit();
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
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Productos;
        private DataGridViewTextBoxColumn Tipo_Producto;
        private DataGridViewTextBoxColumn Num_Serie;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn fecha_fab;
        private DataGridViewTextBoxColumn Vida_util;
        private DataGridViewTextBoxColumn Peso;
        private DataGridViewTextBoxColumn Unidad_peso;
        private DataGridViewTextBoxColumn Largo;
        private DataGridViewTextBoxColumn Ancho;
        private DataGridViewTextBoxColumn Alto;
        private DataGridViewTextBoxColumn IdUnidadMedida;
        private DataGridViewTextBoxColumn tipodemateriales;
        private DataGridViewTextBoxColumn IdPais;
        private DataGridViewTextBoxColumn marca;
        private DataGridViewTextBoxColumn Quitar;
        private DataGridViewButtonColumn Acciones;
    }
}