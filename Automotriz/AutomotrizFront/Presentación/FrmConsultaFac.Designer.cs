namespace AutomotrizFront.Presentación
{
    partial class FrmConsultaFac
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
            label2 = new Label();
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            btnConsultar = new Button();
            btnAtras = new Button();
            label3 = new Label();
            dgvFacturas = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colDetalles = new DataGridViewButtonColumn();
            Colacciones = new DataGridViewButtonColumn();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(135, 115);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "Fecha Desde:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(480, 115);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 1;
            label2.Text = "Fecha Hasta:";
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(135, 141);
            dtpDesde.Margin = new Padding(3, 4, 3, 4);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(156, 27);
            dtpDesde.TabIndex = 2;
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(470, 141);
            dtpHasta.Margin = new Padding(3, 4, 3, 4);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(156, 27);
            dtpHasta.TabIndex = 3;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(717, 137);
            btnConsultar.Margin = new Padding(3, 4, 3, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(86, 31);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(31, 640);
            btnAtras.Margin = new Padding(3, 4, 3, 4);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(86, 31);
            btnAtras.TabIndex = 5;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(289, 29);
            label3.Name = "label3";
            label3.Size = new Size(233, 37);
            label3.TabIndex = 6;
            label3.Text = "Consultar Facturas";
            label3.Click += label3_Click;
            // 
            // dgvFacturas
            // 
            dgvFacturas.AllowUserToAddRows = false;
            dgvFacturas.AllowUserToDeleteRows = false;
            dgvFacturas.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturas.Columns.AddRange(new DataGridViewColumn[] { colID, colFecha, colCliente, colDetalles, Colacciones });
            dgvFacturas.Location = new Point(82, 193);
            dgvFacturas.Margin = new Padding(3, 4, 3, 4);
            dgvFacturas.Name = "dgvFacturas";
            dgvFacturas.ReadOnly = true;
            dgvFacturas.RowHeadersVisible = false;
            dgvFacturas.RowHeadersWidth = 51;
            dgvFacturas.RowTemplate.Height = 25;
            dgvFacturas.Size = new Size(734, 400);
            dgvFacturas.TabIndex = 7;
            dgvFacturas.CellContentClick += dgvFacturas_CellContentClick;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Width = 125;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "FECHA";
            colFecha.MinimumWidth = 6;
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            colFecha.Width = 150;
            // 
            // colCliente
            // 
            colCliente.HeaderText = "CLIENTE";
            colCliente.MinimumWidth = 6;
            colCliente.Name = "colCliente";
            colCliente.ReadOnly = true;
            colCliente.Width = 200;
            // 
            // colDetalles
            // 
            colDetalles.HeaderText = "DETALLES";
            colDetalles.MinimumWidth = 6;
            colDetalles.Name = "colDetalles";
            colDetalles.ReadOnly = true;
            colDetalles.Width = 125;
            // 
            // Colacciones
            // 
            Colacciones.HeaderText = "Accion";
            Colacciones.MinimumWidth = 6;
            Colacciones.Name = "Colacciones";
            Colacciones.ReadOnly = true;
            Colacciones.Resizable = DataGridViewTriState.True;
            Colacciones.SortMode = DataGridViewColumnSortMode.Automatic;
            Colacciones.Width = 125;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.ForeColor = SystemColors.ControlLight;
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 97);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Diseño_sin_título;
            pictureBox1.Location = new Point(13, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // FrmConsultaFac
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(101, 14, 2);
            ClientSize = new Size(863, 687);
            Controls.Add(panel1);
            Controls.Add(dgvFacturas);
            Controls.Add(btnAtras);
            Controls.Add(btnConsultar);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConsultaFac";
            Text = "FrmConsultaFac";
            Load += FrmConsultaFac_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private Button btnConsultar;
        private Button btnAtras;
        private Label label3;
        private DataGridView dgvFacturas;
        private Panel panel1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewButtonColumn colDetalles;
        private DataGridViewButtonColumn Colacciones;
    }
}