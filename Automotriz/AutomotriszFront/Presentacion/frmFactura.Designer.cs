namespace AutomotrizFront.Presentacion
{
    partial class frmFactura
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
            cboTipoFactura = new ComboBox();
            label2 = new Label();
            cboCliente = new ComboBox();
            btnAgregar = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            txtCantidad = new TextBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColProducto = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            ColCantidad = new DataGridViewTextBoxColumn();
            ColAcciones = new DataGridViewButtonColumn();
            button1 = new Button();
            textBox1 = new TextBox();
            btnComparar = new Button();
            label5 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(417, 49);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 1;
            label1.Text = "Tipo factura:";
            // 
            // cboTipoFactura
            // 
            cboTipoFactura.FormattingEnabled = true;
            cboTipoFactura.Location = new Point(505, 48);
            cboTipoFactura.Name = "cboTipoFactura";
            cboTipoFactura.Size = new Size(225, 23);
            cboTipoFactura.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 49);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 3;
            label2.Text = "Cliente:";
            // 
            // cboCliente
            // 
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(98, 48);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(313, 23);
            cboCliente.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(646, 102);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(343, 377);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(58, 103);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 7;
            label3.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(132, 102);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(113, 23);
            txtCantidad.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(287, 103);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 9;
            label4.Text = "Precio:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColId, ColProducto, ColPrecio, ColCantidad, ColAcciones });
            dataGridView1.Location = new Point(68, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(653, 199);
            dataGridView1.TabIndex = 11;
            // 
            // ColId
            // 
            ColId.HeaderText = "Id";
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Visible = false;
            // 
            // ColProducto
            // 
            ColProducto.HeaderText = "Producto";
            ColProducto.Name = "ColProducto";
            ColProducto.ReadOnly = true;
            ColProducto.Width = 310;
            // 
            // ColPrecio
            // 
            ColPrecio.HeaderText = "Precio";
            ColPrecio.Name = "ColPrecio";
            ColPrecio.ReadOnly = true;
            // 
            // ColCantidad
            // 
            ColCantidad.HeaderText = "Cantidad";
            ColCantidad.Name = "ColCantidad";
            ColCantidad.ReadOnly = true;
            // 
            // ColAcciones
            // 
            ColAcciones.HeaderText = "Acción";
            ColAcciones.Name = "ColAcciones";
            ColAcciones.ReadOnly = true;
            ColAcciones.Text = "Quitar";
            ColAcciones.UseColumnTextForButtonValue = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(132, 377);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Cargar";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(346, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 23);
            textBox1.TabIndex = 13;
            // 
            // btnComparar
            // 
            btnComparar.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnComparar.Location = new Point(551, 95);
            btnComparar.Name = "btnComparar";
            btnComparar.Size = new Size(40, 37);
            btnComparar.TabIndex = 14;
            btnComparar.Text = "?";
            btnComparar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(485, 377);
            label5.Name = "label5";
            label5.Size = new Size(53, 23);
            label5.TabIndex = 15;
            label5.Text = "Total:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(544, 377);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 23);
            textBox2.TabIndex = 16;
            // 
            // frmFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(btnComparar);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(txtCantidad);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(cboCliente);
            Controls.Add(label2);
            Controls.Add(cboTipoFactura);
            Controls.Add(label1);
            Name = "frmFactura";
            Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox cboTipoFactura;
        private Label label2;
        private ComboBox cboCliente;
        private Button btnAgregar;
        private Button btnCancelar;
        private Label label3;
        private TextBox txtCantidad;
        private Label label4;
        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColProducto;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewTextBoxColumn ColCantidad;
        private DataGridViewButtonColumn ColAcciones;
        private TextBox textBox1;
        private Button btnComparar;
        private Label label5;
        private TextBox textBox2;
    }
}