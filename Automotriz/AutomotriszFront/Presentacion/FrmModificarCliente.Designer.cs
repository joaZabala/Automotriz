namespace AutomotrizFront.Presentacion
{
    partial class FrmModificarCliente
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
            btnagregar = new Button();
            dgvAltaClientes = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colBarrio = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            colRazonSocial = new DataGridViewTextBoxColumn();
            colCuil = new DataGridViewTextBoxColumn();
            colTipoCli = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewButtonColumn();
            btnCancelar = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cboTipo = new ComboBox();
            cboBarrio = new ComboBox();
            txtCuil = new TextBox();
            txtDireccion = new TextBox();
            txtRazonSocial = new TextBox();
            txtNombre = new TextBox();
            btnAceptar = new Button();
            btnAtras = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAltaClientes).BeginInit();
            SuspendLayout();
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(904, 208);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(121, 29);
            btnagregar.TabIndex = 31;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // dgvAltaClientes
            // 
            dgvAltaClientes.AllowUserToAddRows = false;
            dgvAltaClientes.AllowUserToDeleteRows = false;
            dgvAltaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAltaClientes.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colBarrio, colDireccion, colRazonSocial, colCuil, colTipoCli, colAcciones });
            dgvAltaClientes.Location = new Point(96, 275);
            dgvAltaClientes.Name = "dgvAltaClientes";
            dgvAltaClientes.ReadOnly = true;
            dgvAltaClientes.RowHeadersWidth = 51;
            dgvAltaClientes.RowTemplate.Height = 29;
            dgvAltaClientes.Size = new Size(929, 178);
            dgvAltaClientes.TabIndex = 30;
            dgvAltaClientes.CellContentClick += dgvAltaClientes_CellContentClick;
            // 
            // colId
            // 
            colId.HeaderText = "Column1";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            colId.Width = 125;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 125;
            // 
            // colBarrio
            // 
            colBarrio.HeaderText = "Barrio";
            colBarrio.MinimumWidth = 6;
            colBarrio.Name = "colBarrio";
            colBarrio.ReadOnly = true;
            colBarrio.Width = 125;
            // 
            // colDireccion
            // 
            colDireccion.HeaderText = "Direccion";
            colDireccion.MinimumWidth = 6;
            colDireccion.Name = "colDireccion";
            colDireccion.ReadOnly = true;
            colDireccion.Width = 125;
            // 
            // colRazonSocial
            // 
            colRazonSocial.HeaderText = "Razon Social";
            colRazonSocial.MinimumWidth = 6;
            colRazonSocial.Name = "colRazonSocial";
            colRazonSocial.ReadOnly = true;
            colRazonSocial.Width = 125;
            // 
            // colCuil
            // 
            colCuil.HeaderText = "Cuil";
            colCuil.MinimumWidth = 6;
            colCuil.Name = "colCuil";
            colCuil.ReadOnly = true;
            colCuil.Width = 125;
            // 
            // colTipoCli
            // 
            colTipoCli.HeaderText = "Tipo cliente";
            colTipoCli.MinimumWidth = 6;
            colTipoCli.Name = "colTipoCli";
            colTipoCli.ReadOnly = true;
            colTipoCli.Width = 125;
            // 
            // colAcciones
            // 
            colAcciones.HeaderText = "Acciones";
            colAcciones.MinimumWidth = 6;
            colAcciones.Name = "colAcciones";
            colAcciones.ReadOnly = true;
            colAcciones.Text = "";
            colAcciones.Width = 125;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(607, 490);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(167, 29);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(719, 179);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 27;
            label6.Text = "Tipo Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(471, 177);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 26;
            label5.Text = "Barrio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(187, 177);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 25;
            label4.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(728, 91);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 24;
            label3.Text = "cuil-cuit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(447, 89);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 23;
            label2.Text = "Razon Social";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 89);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 22;
            label1.Text = "Nombre";
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(643, 210);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(238, 28);
            cboTipo.TabIndex = 21;
            // 
            // cboBarrio
            // 
            cboBarrio.FormattingEnabled = true;
            cboBarrio.Location = new Point(390, 208);
            cboBarrio.Name = "cboBarrio";
            cboBarrio.Size = new Size(213, 28);
            cboBarrio.TabIndex = 20;
            // 
            // txtCuil
            // 
            txtCuil.Location = new Point(643, 124);
            txtCuil.Name = "txtCuil";
            txtCuil.Size = new Size(238, 27);
            txtCuil.TabIndex = 19;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(130, 206);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(196, 27);
            txtDireccion.TabIndex = 18;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(390, 122);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(213, 27);
            txtRazonSocial.TabIndex = 17;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(130, 122);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(196, 27);
            txtNombre.TabIndex = 16;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(344, 490);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(167, 29);
            btnAceptar.TabIndex = 32;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(22, 501);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(62, 29);
            btnAtras.TabIndex = 33;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Copperplate Gothic Light", 13.8F, FontStyle.Underline, GraphicsUnit.Point);
            label7.Location = new Point(422, 21);
            label7.Name = "label7";
            label7.Size = new Size(218, 27);
            label7.TabIndex = 34;
            label7.Text = "Moficar Cliente";
            // 
            // FrmModificarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1083, 542);
            Controls.Add(label7);
            Controls.Add(btnAtras);
            Controls.Add(btnAceptar);
            Controls.Add(btnagregar);
            Controls.Add(dgvAltaClientes);
            Controls.Add(btnCancelar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboTipo);
            Controls.Add(cboBarrio);
            Controls.Add(txtCuil);
            Controls.Add(txtDireccion);
            Controls.Add(txtRazonSocial);
            Controls.Add(txtNombre);
            Name = "FrmModificarCliente";
            Text = "Modificar";
            Load += FrmModificarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAltaClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnagregar;
        private DataGridView dgvAltaClientes;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colBarrio;
        private DataGridViewTextBoxColumn colDireccion;
        private DataGridViewTextBoxColumn colRazonSocial;
        private DataGridViewTextBoxColumn colCuil;
        private DataGridViewTextBoxColumn colTipoCli;
        private DataGridViewButtonColumn colAcciones;
        private Button btnCancelar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cboTipo;
        private ComboBox cboBarrio;
        private TextBox txtCuil;
        private TextBox txtDireccion;
        private TextBox txtRazonSocial;
        private TextBox txtNombre;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn colId;
        private Button btnAceptar;
        private Button btnAtras;
        private Label label7;
    }
}