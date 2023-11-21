using AutomotrizBack.Entidades;
namespace AutomotrizFront.Presentacion
{
    partial class FrmFactura
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
            grbMaestro = new GroupBox();
            lblTipoFactura = new Label();
            label1 = new Label();
            cboTipoFactura = new ComboBox();
            cboCliente = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            grbDetalles = new GroupBox();
            dgvDetalles = new DataGridView();
            colProducto = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewButtonColumn();
            btnAgregar = new Button();
            nudCantidad = new NumericUpDown();
            txtPrecio = new TextBox();
            cboProducto = new ComboBox();
            lblCantidad = new Label();
            lblPrecio = new Label();
            lblProducto = new Label();
            btnAtras = new Button();
            pictureBox1 = new PictureBox();
            grbMaestro.SuspendLayout();
            grbDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // grbMaestro
            // 
            grbMaestro.BackColor = Color.FromArgb(101, 14, 2);
            grbMaestro.Controls.Add(lblTipoFactura);
            grbMaestro.Controls.Add(label1);
            grbMaestro.Controls.Add(cboTipoFactura);
            grbMaestro.Controls.Add(cboCliente);
            grbMaestro.Location = new Point(153, 98);
            grbMaestro.Margin = new Padding(4, 3, 4, 3);
            grbMaestro.Name = "grbMaestro";
            grbMaestro.Padding = new Padding(4, 3, 4, 3);
            grbMaestro.Size = new Size(861, 115);
            grbMaestro.TabIndex = 8;
            grbMaestro.TabStop = false;
            // 
            // lblTipoFactura
            // 
            lblTipoFactura.AutoSize = true;
            lblTipoFactura.Font = new Font("Georgia", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoFactura.ForeColor = SystemColors.ButtonFace;
            lblTipoFactura.Location = new Point(453, 32);
            lblTipoFactura.Margin = new Padding(4, 0, 4, 0);
            lblTipoFactura.Name = "lblTipoFactura";
            lblTipoFactura.Size = new Size(139, 18);
            lblTipoFactura.TabIndex = 7;
            lblTipoFactura.Text = " Tipo de Factura:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(228, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 18);
            label1.TabIndex = 6;
            label1.Text = "Elegir Cliente: ";
            // 
            // cboTipoFactura
            // 
            cboTipoFactura.FormattingEnabled = true;
            cboTipoFactura.Location = new Point(444, 61);
            cboTipoFactura.Margin = new Padding(4, 3, 4, 3);
            cboTipoFactura.Name = "cboTipoFactura";
            cboTipoFactura.Size = new Size(181, 23);
            cboTipoFactura.TabIndex = 5;
            // 
            // cboCliente
            // 
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(195, 61);
            cboCliente.Margin = new Padding(4, 3, 4, 3);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(185, 23);
            cboCliente.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ControlLight;
            btnGuardar.ForeColor = SystemColors.ActiveCaptionText;
            btnGuardar.Location = new Point(459, 564);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 27);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlLight;
            btnCancelar.Location = new Point(606, 564);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 27);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // grbDetalles
            // 
            grbDetalles.BackColor = Color.FromArgb(101, 14, 2);
            grbDetalles.Controls.Add(dgvDetalles);
            grbDetalles.Controls.Add(btnAgregar);
            grbDetalles.Controls.Add(nudCantidad);
            grbDetalles.Controls.Add(txtPrecio);
            grbDetalles.Controls.Add(cboProducto);
            grbDetalles.Controls.Add(lblCantidad);
            grbDetalles.Controls.Add(lblPrecio);
            grbDetalles.Controls.Add(lblProducto);
            grbDetalles.Location = new Point(153, 246);
            grbDetalles.Margin = new Padding(4, 3, 4, 3);
            grbDetalles.Name = "grbDetalles";
            grbDetalles.Padding = new Padding(4, 3, 4, 3);
            grbDetalles.Size = new Size(861, 304);
            grbDetalles.TabIndex = 16;
            grbDetalles.TabStop = false;
            grbDetalles.Enter += grbDetalles_Enter;
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Columns.AddRange(new DataGridViewColumn[] { colProducto, colPrecio, colCantidad, colAcciones });
            dgvDetalles.GridColor = SystemColors.ActiveCaptionText;
            dgvDetalles.Location = new Point(63, 96);
            dgvDetalles.Margin = new Padding(4, 3, 4, 3);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.ReadOnly = true;
            dgvDetalles.RowHeadersVisible = false;
            dgvDetalles.RowHeadersWidth = 51;
            dgvDetalles.Size = new Size(763, 189);
            dgvDetalles.TabIndex = 26;
            dgvDetalles.CellContentClick += dgvDetalles_CellContentClick;
            // 
            // colProducto
            // 
            colProducto.HeaderText = "PRODUCTO";
            colProducto.MinimumWidth = 6;
            colProducto.Name = "colProducto";
            colProducto.ReadOnly = true;
            colProducto.Width = 400;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "PRECIO";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            colPrecio.Width = 150;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "CANTIDAD";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            colCantidad.Width = 125;
            // 
            // colAcciones
            // 
            colAcciones.HeaderText = "Acciones";
            colAcciones.MinimumWidth = 6;
            colAcciones.Name = "colAcciones";
            colAcciones.ReadOnly = true;
            colAcciones.Width = 125;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(756, 51);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(88, 27);
            btnAgregar.TabIndex = 25;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(642, 56);
            nudCantidad.Margin = new Padding(4, 3, 4, 3);
            nudCantidad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(81, 23);
            nudCantidad.TabIndex = 23;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(497, 55);
            txtPrecio.Margin = new Padding(4, 3, 4, 3);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(88, 23);
            txtPrecio.TabIndex = 22;
            // 
            // cboProducto
            // 
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(63, 57);
            cboProducto.Margin = new Padding(4, 3, 4, 3);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(376, 23);
            cboProducto.TabIndex = 21;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Georgia", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantidad.ForeColor = SystemColors.ButtonFace;
            lblCantidad.Location = new Point(634, 31);
            lblCantidad.Margin = new Padding(4, 0, 4, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(84, 18);
            lblCantidad.TabIndex = 19;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Georgia", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecio.ForeColor = SystemColors.ButtonFace;
            lblPrecio.Location = new Point(497, 29);
            lblPrecio.Margin = new Padding(4, 0, 4, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(63, 18);
            lblPrecio.TabIndex = 18;
            lblPrecio.Text = "Precio:";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Georgia", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblProducto.ForeColor = SystemColors.ButtonFace;
            lblProducto.Location = new Point(172, 31);
            lblProducto.Margin = new Padding(4, 0, 4, 0);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(151, 18);
            lblProducto.TabIndex = 17;
            lblProducto.Text = "Elegir el Producto:";
            // 
            // btnAtras
            // 
            btnAtras.BackColor = SystemColors.ControlLight;
            btnAtras.Location = new Point(28, 593);
            btnAtras.Margin = new Padding(4, 3, 4, 3);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(88, 27);
            btnAtras.TabIndex = 17;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Diseño_sin_título;
            pictureBox1.Location = new Point(28, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // FrmFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1131, 637);
            Controls.Add(pictureBox1);
            Controls.Add(btnAtras);
            Controls.Add(grbDetalles);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(grbMaestro);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFactura";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmFactura";
            Load += FrmFactura_Load;
            grbMaestro.ResumeLayout(false);
            grbMaestro.PerformLayout();
            grbDetalles.ResumeLayout(false);
            grbDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grbMaestro;
        private Label lblTipoFactura;
        private Label label1;
        private ComboBox cboTipoFactura;
        private ComboBox cboCliente;
        private Button btnGuardar;
        private Button btnCancelar;
        private GroupBox grbDetalles;
        private DataGridView dgvDetalles;
        private Button btnAgregar;
        private NumericUpDown nudCantidad;
        private TextBox txtPrecio;
        private ComboBox cboProducto;
        private Label lblCantidad;
        private Label lblPrecio;
        private Label lblProducto;
        private Button btnAtras;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewButtonColumn colAcciones;
    }
}

