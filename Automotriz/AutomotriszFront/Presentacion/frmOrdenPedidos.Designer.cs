namespace AutomotrizFront.Presentacion
{
    partial class frmOrdenPedidos
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
            dtpFechaEntrega = new DateTimePicker();
            label1 = new Label();
            cboProducto = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtCantidad = new TextBox();
            dataGridView1 = new DataGridView();
            btnAgregar = new Button();
            btnCargar = new Button();
            ColId = new DataGridViewTextBoxColumn();
            ColProducto = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            ColCantidad = new DataGridViewTextBoxColumn();
            ColAccion = new DataGridViewButtonColumn();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.Format = DateTimePickerFormat.Short;
            dtpFechaEntrega.Location = new Point(207, 36);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(105, 23);
            dtpFechaEntrega.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(54, 36);
            label1.Name = "label1";
            label1.Size = new Size(147, 19);
            label1.TabIndex = 1;
            label1.Text = "Fecha de entrega:";
            // 
            // cboProducto
            // 
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(146, 87);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(231, 23);
            cboProducto.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(54, 89);
            label2.Name = "label2";
            label2.Size = new Size(86, 19);
            label2.TabIndex = 3;
            label2.Text = "Producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(405, 89);
            label3.Name = "label3";
            label3.Size = new Size(84, 19);
            label3.TabIndex = 4;
            label3.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(495, 87);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(109, 23);
            txtCantidad.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColId, ColProducto, ColPrecio, ColCantidad, ColAccion });
            dataGridView1.Location = new Point(54, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(694, 150);
            dataGridView1.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(650, 88);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(87, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(252, 340);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 8;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
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
            ColProducto.Width = 350;
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
            // ColAccion
            // 
            ColAccion.HeaderText = "Acción";
            ColAccion.Name = "ColAccion";
            ColAccion.ReadOnly = true;
            ColAccion.Text = "Quitar";
            ColAccion.UseColumnTextForButtonValue = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(456, 340);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmOrdenPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnCargar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Controls.Add(txtCantidad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboProducto);
            Controls.Add(label1);
            Controls.Add(dtpFechaEntrega);
            Name = "frmOrdenPedidos";
            Text = "Orden de pedidos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFechaEntrega;
        private Label label1;
        private ComboBox cboProducto;
        private Label label2;
        private Label label3;
        private TextBox txtCantidad;
        private DataGridView dataGridView1;
        private Button btnAgregar;
        private Button btnCargar;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColProducto;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewTextBoxColumn ColCantidad;
        private DataGridViewButtonColumn ColAccion;
        private Button btnCancelar;
    }
}