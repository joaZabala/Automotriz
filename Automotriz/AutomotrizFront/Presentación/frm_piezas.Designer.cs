namespace AutomotrizFront.Presentación
{
    partial class frm_piezas
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
            dgv_piezas = new DataGridView();
            c_año = new DataGridViewTextBoxColumn();
            c_producto = new DataGridViewTextBoxColumn();
            c_cantidad = new DataGridViewTextBoxColumn();
            c_ubicacion = new DataGridViewTextBoxColumn();
            btn_consultar = new Button();
            btn_salir = new Button();
            cbo_zona = new ComboBox();
            nud_cantidad = new NumericUpDown();
            lbl_zona = new Label();
            lbl_cantidad = new Label();
            btn_help = new Button();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_piezas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_cantidad).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgv_piezas
            // 
            dgv_piezas.AllowUserToAddRows = false;
            dgv_piezas.AllowUserToDeleteRows = false;
            dgv_piezas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_piezas.Columns.AddRange(new DataGridViewColumn[] { c_año, c_producto, c_cantidad, c_ubicacion });
            dgv_piezas.Location = new Point(45, 201);
            dgv_piezas.Name = "dgv_piezas";
            dgv_piezas.ReadOnly = true;
            dgv_piezas.RowHeadersWidth = 51;
            dgv_piezas.RowTemplate.Height = 25;
            dgv_piezas.Size = new Size(551, 150);
            dgv_piezas.TabIndex = 0;
            dgv_piezas.CellContentClick += dgv_piezas_CellContentClick;
            // 
            // c_año
            // 
            c_año.HeaderText = "Año y Mes de Fabricacion";
            c_año.MinimumWidth = 6;
            c_año.Name = "c_año";
            c_año.ReadOnly = true;
            c_año.Width = 200;
            // 
            // c_producto
            // 
            c_producto.HeaderText = "Producto";
            c_producto.MinimumWidth = 6;
            c_producto.Name = "c_producto";
            c_producto.ReadOnly = true;
            c_producto.Width = 125;
            // 
            // c_cantidad
            // 
            c_cantidad.HeaderText = "Cantidad";
            c_cantidad.MinimumWidth = 6;
            c_cantidad.Name = "c_cantidad";
            c_cantidad.ReadOnly = true;
            c_cantidad.Width = 125;
            // 
            // c_ubicacion
            // 
            c_ubicacion.HeaderText = "Ubicacion";
            c_ubicacion.MinimumWidth = 6;
            c_ubicacion.Name = "c_ubicacion";
            c_ubicacion.ReadOnly = true;
            c_ubicacion.Width = 125;
            // 
            // btn_consultar
            // 
            btn_consultar.Location = new Point(514, 160);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(75, 23);
            btn_consultar.TabIndex = 1;
            btn_consultar.Text = "Consultar";
            btn_consultar.UseVisualStyleBackColor = true;
            btn_consultar.Click += btn_consultar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(572, 368);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(75, 23);
            btn_salir.TabIndex = 2;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // cbo_zona
            // 
            cbo_zona.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_zona.FormattingEnabled = true;
            cbo_zona.Location = new Point(45, 95);
            cbo_zona.Name = "cbo_zona";
            cbo_zona.Size = new Size(216, 23);
            cbo_zona.TabIndex = 3;
            // 
            // nud_cantidad
            // 
            nud_cantidad.Location = new Point(45, 160);
            nud_cantidad.Name = "nud_cantidad";
            nud_cantidad.Size = new Size(215, 23);
            nud_cantidad.TabIndex = 4;
            // 
            // lbl_zona
            // 
            lbl_zona.AutoSize = true;
            lbl_zona.BackColor = Color.Transparent;
            lbl_zona.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_zona.ForeColor = SystemColors.ButtonFace;
            lbl_zona.Location = new Point(44, 75);
            lbl_zona.Name = "lbl_zona";
            lbl_zona.Size = new Size(44, 17);
            lbl_zona.TabIndex = 5;
            lbl_zona.Text = "Zona";
            // 
            // lbl_cantidad
            // 
            lbl_cantidad.AutoSize = true;
            lbl_cantidad.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cantidad.ForeColor = SystemColors.ButtonFace;
            lbl_cantidad.Location = new Point(45, 142);
            lbl_cantidad.Name = "lbl_cantidad";
            lbl_cantidad.Size = new Size(134, 17);
            lbl_cantidad.TabIndex = 6;
            lbl_cantidad.Text = "Cantidad Minima";
            lbl_cantidad.Click += label2_Click;
            // 
            // btn_help
            // 
            btn_help.Location = new Point(514, 93);
            btn_help.Name = "btn_help";
            btn_help.Size = new Size(75, 23);
            btn_help.TabIndex = 7;
            btn_help.Text = "Ayuda";
            btn_help.UseVisualStyleBackColor = true;
            btn_help.Click += btn_help_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(-4, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 62);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(302, 22);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 69;
            label2.Text = "Piezas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Diseño_sin_título;
            pictureBox1.Location = new Point(18, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 68;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(207, 22);
            label1.Name = "label1";
            label1.Size = new Size(0, 17);
            label1.TabIndex = 4;
            // 
            // frm_piezas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(101, 14, 2);
            ClientSize = new Size(658, 401);
            Controls.Add(panel1);
            Controls.Add(btn_help);
            Controls.Add(lbl_cantidad);
            Controls.Add(lbl_zona);
            Controls.Add(nud_cantidad);
            Controls.Add(cbo_zona);
            Controls.Add(btn_salir);
            Controls.Add(btn_consultar);
            Controls.Add(dgv_piezas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_piezas";
            Text = "Ubicador de Piezas en la Compania";
            Load += frm_piezas_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_piezas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_cantidad).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_piezas;
        private DataGridViewTextBoxColumn c_año;
        private DataGridViewTextBoxColumn c_producto;
        private DataGridViewTextBoxColumn c_cantidad;
        private DataGridViewTextBoxColumn c_ubicacion;
        private Button btn_consultar;
        private Button btn_salir;
        private ComboBox cbo_zona;
        private NumericUpDown nud_cantidad;
        private Label lbl_zona;
        private Label lbl_cantidad;
        private Button btn_help;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}