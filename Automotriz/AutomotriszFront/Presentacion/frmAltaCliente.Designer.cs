﻿namespace AutomotriszFront.Presentacion
{
    partial class frmAltaCliente
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
            txtNombre = new TextBox();
            txtRazonSocial = new TextBox();
            txtDireccion = new TextBox();
            txtCuil = new TextBox();
            cboBarrio = new ComboBox();
            cboTipo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            btnCancelar = new Button();
            dgvAltaClientes = new DataGridView();
            btnagregar = new Button();
            btnAtras = new Button();
            btnSalir = new Button();
            cboTipoContacto = new ComboBox();
            label7 = new Label();
            txtContacto = new TextBox();
            label8 = new Label();
            colNombre = new DataGridViewTextBoxColumn();
            colBarrio = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            colRazonSocial = new DataGridViewTextBoxColumn();
            colCuil = new DataGridViewTextBoxColumn();
            colTipoCli = new DataGridViewTextBoxColumn();
            colContacto = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAltaClientes).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(48, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(196, 27);
            txtNombre.TabIndex = 0;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(273, 82);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(213, 27);
            txtRazonSocial.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(48, 166);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(196, 27);
            txtDireccion.TabIndex = 2;
            // 
            // txtCuil
            // 
            txtCuil.Location = new Point(521, 82);
            txtCuil.Name = "txtCuil";
            txtCuil.Size = new Size(238, 27);
            txtCuil.TabIndex = 3;
            txtCuil.KeyPress += txtCuil_KeyPress;
            // 
            // cboBarrio
            // 
            cboBarrio.FormattingEnabled = true;
            cboBarrio.Location = new Point(273, 168);
            cboBarrio.Name = "cboBarrio";
            cboBarrio.Size = new Size(213, 28);
            cboBarrio.TabIndex = 4;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(521, 168);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(238, 28);
            cboTipo.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 49);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 49);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 7;
            label2.Text = "Razon Social";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(606, 49);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 8;
            label3.Text = "cuil-cuit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 137);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 9;
            label4.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(359, 137);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 10;
            label5.Text = "Barrio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(597, 137);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 11;
            label6.Text = "Tipo Cliente";
            // 
            // button1
            // 
            button1.Location = new Point(359, 448);
            button1.Name = "button1";
            button1.Size = new Size(167, 29);
            button1.TabIndex = 12;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(658, 448);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(167, 29);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvAltaClientes
            // 
            dgvAltaClientes.AllowUserToAddRows = false;
            dgvAltaClientes.AllowUserToDeleteRows = false;
            dgvAltaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAltaClientes.Columns.AddRange(new DataGridViewColumn[] { colNombre, colBarrio, colDireccion, colRazonSocial, colCuil, colTipoCli, colContacto, colAcciones });
            dgvAltaClientes.Location = new Point(48, 239);
            dgvAltaClientes.Name = "dgvAltaClientes";
            dgvAltaClientes.ReadOnly = true;
            dgvAltaClientes.RowHeadersWidth = 51;
            dgvAltaClientes.RowTemplate.Height = 29;
            dgvAltaClientes.Size = new Size(1058, 175);
            dgvAltaClientes.TabIndex = 14;
            dgvAltaClientes.CellContentClick += dgvAltaClientes_CellContentClick;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(1040, 161);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(81, 37);
            btnagregar.TabIndex = 15;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(12, 528);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(87, 28);
            btnAtras.TabIndex = 16;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1043, 528);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(87, 28);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // cboTipoContacto
            // 
            cboTipoContacto.FormattingEnabled = true;
            cboTipoContacto.Location = new Point(779, 82);
            cboTipoContacto.Name = "cboTipoContacto";
            cboTipoContacto.Size = new Size(230, 28);
            cboTipoContacto.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(843, 49);
            label7.Name = "label7";
            label7.Size = new Size(103, 20);
            label7.TabIndex = 19;
            label7.Text = "Tipo Contacto";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(779, 169);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(238, 27);
            txtContacto.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(861, 137);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 21;
            label8.Text = "Contacto";
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
            // colContacto
            // 
            colContacto.HeaderText = "Contacto";
            colContacto.MinimumWidth = 6;
            colContacto.Name = "colContacto";
            colContacto.ReadOnly = true;
            colContacto.Width = 125;
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
            // frmAltaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 559);
            Controls.Add(label8);
            Controls.Add(txtContacto);
            Controls.Add(label7);
            Controls.Add(cboTipoContacto);
            Controls.Add(btnSalir);
            Controls.Add(btnAtras);
            Controls.Add(btnagregar);
            Controls.Add(dgvAltaClientes);
            Controls.Add(btnCancelar);
            Controls.Add(button1);
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
            Name = "frmAltaCliente";
            Text = "Registrar cliente";
            Load += frmAltaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAltaClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtRazonSocial;
        private TextBox txtDireccion;
        private TextBox txtCuil;
        private ComboBox cboBarrio;
        private ComboBox cboTipo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button btnCancelar;
        private DataGridView dgvAltaClientes;
        private Button btnagregar;
        private Button btnAtras;
        private Button btnSalir;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colBarrio;
        private DataGridViewTextBoxColumn colDireccion;
        private DataGridViewTextBoxColumn colRazonSocial;
        private DataGridViewTextBoxColumn colCuil;
        private DataGridViewTextBoxColumn colTipoCli;
        private DataGridViewTextBoxColumn colContacto;
        private DataGridViewButtonColumn colAcciones;
        private ComboBox cboTipoContacto;
        private Label label7;
        private TextBox txtContacto;
        private Label label8;
    }
}