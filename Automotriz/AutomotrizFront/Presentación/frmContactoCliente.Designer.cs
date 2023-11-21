namespace AutomotrizFront.Presentación
{
    partial class frmContactoCliente
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
            dgvContactos = new DataGridView();
            ColContacto = new DataGridViewTextBoxColumn();
            ColTipoContacto = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContactos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvContactos
            // 
            dgvContactos.AllowUserToAddRows = false;
            dgvContactos.AllowUserToDeleteRows = false;
            dgvContactos.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactos.Columns.AddRange(new DataGridViewColumn[] { ColContacto, ColTipoContacto });
            dgvContactos.Location = new Point(151, 95);
            dgvContactos.Name = "dgvContactos";
            dgvContactos.ReadOnly = true;
            dgvContactos.RowHeadersWidth = 51;
            dgvContactos.RowTemplate.Height = 25;
            dgvContactos.Size = new Size(355, 167);
            dgvContactos.TabIndex = 1;
            // 
            // ColContacto
            // 
            ColContacto.HeaderText = "Contacto";
            ColContacto.MinimumWidth = 6;
            ColContacto.Name = "ColContacto";
            ColContacto.ReadOnly = true;
            ColContacto.Width = 150;
            // 
            // ColTipoContacto
            // 
            ColTipoContacto.HeaderText = "Tipo Contacto";
            ColTipoContacto.MinimumWidth = 6;
            ColTipoContacto.Name = "ColTipoContacto";
            ColTipoContacto.ReadOnly = true;
            ColTipoContacto.Width = 200;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-3, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(625, 76);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(266, 26);
            label1.Name = "label1";
            label1.Size = new Size(114, 27);
            label1.TabIndex = 3;
            label1.Text = "Contacto";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Diseño_sin_título;
            pictureBox1.Location = new Point(21, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(10, 277);
            btnAtras.Margin = new Padding(3, 2, 3, 2);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(82, 22);
            btnAtras.TabIndex = 3;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // frmContactoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(101, 14, 2);
            ClientSize = new Size(620, 308);
            Controls.Add(btnAtras);
            Controls.Add(panel1);
            Controls.Add(dgvContactos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmContactoCliente";
            Text = "Contacto Cliente";
            Load += frmContactoCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContactos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvContactos;
        private DataGridViewTextBoxColumn ColContacto;
        private DataGridViewTextBoxColumn ColTipoContacto;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnAtras;
    }
}