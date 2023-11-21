namespace AutomotrizFront.Presentación
{
    partial class FrmConsultarTotal
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
            groupBox1 = new GroupBox();
            btnConsultar = new Button();
            label2 = new Label();
            label1 = new Label();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            label3 = new Label();
            dgvTotal = new DataGridView();
            ColTotal = new DataGridViewTextBoxColumn();
            ColPromedio = new DataGridViewTextBoxColumn();
            ColCantidadFac = new DataGridViewTextBoxColumn();
            btnSalir = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(101, 14, 2);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtpHasta);
            groupBox1.Controls.Add(dtpDesde);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(119, 104);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(720, 116);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.LightGray;
            btnConsultar.ForeColor = SystemColors.ActiveCaptionText;
            btnConsultar.Location = new Point(629, 80);
            btnConsultar.Margin = new Padding(3, 2, 3, 2);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(82, 22);
            btnConsultar.TabIndex = 3;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(348, 42);
            label2.Name = "label2";
            label2.Size = new Size(104, 18);
            label2.TabIndex = 7;
            label2.Text = "Fecha hasta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(16, 42);
            label1.Name = "label1";
            label1.Size = new Size(108, 18);
            label1.TabIndex = 6;
            label1.Text = "Fecha Desde:";
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(474, 39);
            dtpHasta.Margin = new Padding(3, 2, 3, 2);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(192, 23);
            dtpHasta.TabIndex = 5;
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(138, 42);
            dtpDesde.Margin = new Padding(3, 2, 3, 2);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(176, 23);
            dtpDesde.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(399, 41);
            label3.Name = "label3";
            label3.Size = new Size(187, 27);
            label3.TabIndex = 2;
            label3.Text = "Montos Totales";
            // 
            // dgvTotal
            // 
            dgvTotal.AllowUserToAddRows = false;
            dgvTotal.AllowUserToDeleteRows = false;
            dgvTotal.BackgroundColor = Color.Black;
            dgvTotal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTotal.Columns.AddRange(new DataGridViewColumn[] { ColTotal, ColPromedio, ColCantidadFac });
            dgvTotal.Location = new Point(248, 236);
            dgvTotal.Margin = new Padding(3, 2, 3, 2);
            dgvTotal.Name = "dgvTotal";
            dgvTotal.ReadOnly = true;
            dgvTotal.RowHeadersWidth = 51;
            dgvTotal.RowTemplate.Height = 29;
            dgvTotal.Size = new Size(508, 141);
            dgvTotal.TabIndex = 0;
            dgvTotal.CellContentClick += dgvTotal_CellContentClick;
            // 
            // ColTotal
            // 
            ColTotal.FillWeight = 250F;
            ColTotal.HeaderText = "Total";
            ColTotal.MinimumWidth = 6;
            ColTotal.Name = "ColTotal";
            ColTotal.ReadOnly = true;
            ColTotal.Width = 200;
            // 
            // ColPromedio
            // 
            ColPromedio.FillWeight = 250F;
            ColPromedio.HeaderText = "Promedio";
            ColPromedio.MinimumWidth = 6;
            ColPromedio.Name = "ColPromedio";
            ColPromedio.ReadOnly = true;
            ColPromedio.Width = 200;
            // 
            // ColCantidadFac
            // 
            ColCantidadFac.FillWeight = 250F;
            ColCantidadFac.HeaderText = "Cantidad de facturas";
            ColCantidadFac.MinimumWidth = 6;
            ColCantidadFac.Name = "ColCantidadFac";
            ColCantidadFac.ReadOnly = true;
            ColCantidadFac.Width = 125;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LightGray;
            btnSalir.Location = new Point(846, 386);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(82, 22);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Location = new Point(42, 386);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(57, 22);
            button1.TabIndex = 5;
            button1.Text = "Ayuda";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Diseño_sin_título;
            pictureBox1.Location = new Point(10, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 66;
            pictureBox1.TabStop = false;
            // 
            // FrmConsultarTotal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(960, 412);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(btnSalir);
            Controls.Add(dgvTotal);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConsultarTotal";
            Text = "FrmConsultarTotal";
            Load += FrmConsultarTotal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private Label label3;
        private Button btnConsultar;
        private DataGridView dgvTotal;
        private Button btnSalir;
        private Button button1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn ColTotal;
        private DataGridViewTextBoxColumn ColPromedio;
        private DataGridViewTextBoxColumn ColCantidadFac;
    }
}