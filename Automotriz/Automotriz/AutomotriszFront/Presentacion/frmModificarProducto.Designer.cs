namespace AutomotrizFront.Presentacion
{
    partial class frmModificarProducto
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
            label15 = new Label();
            btnAtras = new Button();
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
            label17 = new Label();
            label16 = new Label();
            btnActualizar = new Button();
            dtpFec_fab = new DateTimePicker();
            txtAncho = new TextBox();
            txtLargo = new TextBox();
            txtNum = new TextBox();
            txtPrecio = new TextBox();
            txtAlto = new TextBox();
            txtPeso = new TextBox();
            txtVida = new TextBox();
            txtProducto = new TextBox();
            cboPais = new ComboBox();
            cboUnidPes = new ComboBox();
            cboUnidMed = new ComboBox();
            cboMarca = new ComboBox();
            cboMaterial = new ComboBox();
            cboTpProd = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgProductos).BeginInit();
            SuspendLayout();
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(783, 19);
            label15.Name = "label15";
            label15.Size = new Size(28, 15);
            label15.TabIndex = 205;
            label15.Text = "Pais";
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(16, 406);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(84, 28);
            btnAtras.TabIndex = 204;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            // 
            // dvgProductos
            // 
            dvgProductos.AllowUserToAddRows = false;
            dvgProductos.AllowUserToDeleteRows = false;
            dvgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProductos.Columns.AddRange(new DataGridViewColumn[] { ID, Productos, Tipo_Producto, Num_Serie, Precio, fecha_fab, Vida_util, Peso, Unidad_peso, Largo, Ancho, Alto, IdUnidadMedida, tipodemateriales, IdPais, marca });
            dvgProductos.Location = new Point(63, 234);
            dvgProductos.Name = "dvgProductos";
            dvgProductos.ReadOnly = true;
            dvgProductos.RowTemplate.Height = 25;
            dvgProductos.Size = new Size(859, 166);
            dvgProductos.TabIndex = 203;
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
            // label17
            // 
            label17.AutoSize = true;
            label17.BorderStyle = BorderStyle.Fixed3D;
            label17.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(107, 9);
            label17.Name = "label17";
            label17.Size = new Size(97, 26);
            label17.TabIndex = 202;
            label17.Text = "Modificar";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(72, 24);
            label16.Name = "label16";
            label16.Size = new Size(0, 15);
            label16.TabIndex = 201;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(839, 109);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(84, 42);
            btnActualizar.TabIndex = 200;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dtpFec_fab
            // 
            dtpFec_fab.Location = new Point(107, 196);
            dtpFec_fab.Name = "dtpFec_fab";
            dtpFec_fab.Size = new Size(200, 23);
            dtpFec_fab.TabIndex = 199;
            // 
            // txtAncho
            // 
            txtAncho.Location = new Point(643, 62);
            txtAncho.Name = "txtAncho";
            txtAncho.Size = new Size(68, 23);
            txtAncho.TabIndex = 198;
            // 
            // txtLargo
            // 
            txtLargo.Location = new Point(643, 21);
            txtLargo.Name = "txtLargo";
            txtLargo.Size = new Size(68, 23);
            txtLargo.TabIndex = 197;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(107, 106);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 196;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(107, 148);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 195;
            // 
            // txtAlto
            // 
            txtAlto.Location = new Point(434, 65);
            txtAlto.Name = "txtAlto";
            txtAlto.Size = new Size(68, 23);
            txtAlto.TabIndex = 194;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(434, 148);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(74, 23);
            txtPeso.TabIndex = 193;
            // 
            // txtVida
            // 
            txtVida.Location = new Point(434, 106);
            txtVida.Name = "txtVida";
            txtVida.Size = new Size(74, 23);
            txtVida.TabIndex = 192;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(107, 62);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(173, 23);
            txtProducto.TabIndex = 191;
            // 
            // cboPais
            // 
            cboPais.FormattingEnabled = true;
            cboPais.Location = new Point(817, 16);
            cboPais.Name = "cboPais";
            cboPais.Size = new Size(129, 23);
            cboPais.TabIndex = 190;
            // 
            // cboUnidPes
            // 
            cboUnidPes.FormattingEnabled = true;
            cboUnidPes.Location = new Point(434, 196);
            cboUnidPes.Name = "cboUnidPes";
            cboUnidPes.Size = new Size(129, 23);
            cboUnidPes.TabIndex = 189;
            // 
            // cboUnidMed
            // 
            cboUnidMed.FormattingEnabled = true;
            cboUnidMed.Location = new Point(434, 21);
            cboUnidMed.Name = "cboUnidMed";
            cboUnidMed.Size = new Size(129, 23);
            cboUnidMed.TabIndex = 188;
            // 
            // cboMarca
            // 
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(817, 59);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(129, 23);
            cboMarca.TabIndex = 187;
            // 
            // cboMaterial
            // 
            cboMaterial.FormattingEnabled = true;
            cboMaterial.Location = new Point(643, 143);
            cboMaterial.Name = "cboMaterial";
            cboMaterial.Size = new Size(147, 23);
            cboMaterial.TabIndex = 186;
            // 
            // cboTpProd
            // 
            cboTpProd.FormattingEnabled = true;
            cboTpProd.Location = new Point(643, 106);
            cboTpProd.Name = "cboTpProd";
            cboTpProd.Size = new Size(147, 23);
            cboTpProd.TabIndex = 185;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(771, 65);
            label14.Name = "label14";
            label14.Size = new Size(40, 15);
            label14.TabIndex = 184;
            label14.Text = "Marca";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(581, 151);
            label13.Name = "label13";
            label13.Size = new Size(50, 15);
            label13.TabIndex = 183;
            label13.Text = "Material";
            // 
            // label12
            // 
            label12.AccessibleRole = AccessibleRole.IpAddress;
            label12.AutoSize = true;
            label12.Location = new Point(349, 16);
            label12.Name = "label12";
            label12.Size = new Size(61, 30);
            label12.TabIndex = 182;
            label12.Text = "Unidad de\r\n Medida\r\n";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(600, 65);
            label11.Name = "label11";
            label11.Size = new Size(42, 15);
            label11.TabIndex = 181;
            label11.Text = "Ancho\r\n";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(378, 70);
            label10.Name = "label10";
            label10.Size = new Size(29, 15);
            label10.TabIndex = 180;
            label10.Text = "Alto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(600, 24);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 179;
            label9.Text = "Largo";
            // 
            // label8
            // 
            label8.AccessibleRole = AccessibleRole.IpAddress;
            label8.AutoSize = true;
            label8.Location = new Point(346, 189);
            label8.Name = "label8";
            label8.Size = new Size(61, 30);
            label8.TabIndex = 178;
            label8.Text = "Unidad de\r\npeso\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(375, 156);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 177;
            label7.Text = "Peso";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(356, 109);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 176;
            label6.Text = "Vida Util";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(581, 99);
            label5.Name = "label5";
            label5.Size = new Size(56, 30);
            label5.TabIndex = 175;
            label5.Text = "Tipo \r\nProducto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 156);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 174;
            label4.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 189);
            label3.Name = "label3";
            label3.Size = new Size(66, 30);
            label3.TabIndex = 173;
            label3.Text = "Fecha de\r\nfabricacion\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 99);
            label2.Name = "label2";
            label2.Size = new Size(67, 30);
            label2.TabIndex = 172;
            label2.Text = "Numero de\r\nserie\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 62);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 171;
            label1.Text = "Producto";
            // 
            // frmModificarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 440);
            Controls.Add(label15);
            Controls.Add(btnAtras);
            Controls.Add(dvgProductos);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(btnActualizar);
            Controls.Add(dtpFec_fab);
            Controls.Add(txtAncho);
            Controls.Add(txtLargo);
            Controls.Add(txtNum);
            Controls.Add(txtPrecio);
            Controls.Add(txtAlto);
            Controls.Add(txtPeso);
            Controls.Add(txtVida);
            Controls.Add(txtProducto);
            Controls.Add(cboPais);
            Controls.Add(cboUnidPes);
            Controls.Add(cboUnidMed);
            Controls.Add(cboMarca);
            Controls.Add(cboMaterial);
            Controls.Add(cboTpProd);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmModificarProducto";
            Text = "frmModificarProducto";
            Load += frmModificarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dvgProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label15;
        private Button btnAtras;
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
        private Label label17;
        private Label label16;
        private Button btnActualizar;
        private DateTimePicker dtpFec_fab;
        private TextBox txtAncho;
        private TextBox txtLargo;
        private TextBox txtNum;
        private TextBox txtPrecio;
        private TextBox txtAlto;
        private TextBox txtPeso;
        private TextBox txtVida;
        private TextBox txtProducto;
        private ComboBox cboPais;
        private ComboBox cboUnidPes;
        private ComboBox cboUnidMed;
        private ComboBox cboMarca;
        private ComboBox cboMaterial;
        private ComboBox cboTpProd;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}