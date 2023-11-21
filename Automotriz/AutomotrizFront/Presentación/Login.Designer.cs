namespace AutomotrizFront.Presentacion
{
    partial class Login
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
            button2 = new Button();
            groupBox1 = new GroupBox();
            btnIngresar = new Button();
            label2 = new Label();
            label1 = new Label();
            txtContra = new TextBox();
            txtUser = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(735, 496);
            button2.Name = "button2";
            button2.Size = new Size(66, 22);
            button2.TabIndex = 5;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(101, 14, 2);
            groupBox1.Controls.Add(btnIngresar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtContra);
            groupBox1.Controls.Add(txtUser);
            groupBox1.Location = new Point(296, 143);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(336, 291);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Transparent;
            btnIngresar.Location = new Point(119, 230);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(102, 29);
            btnIngresar.TabIndex = 9;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(119, 144);
            label2.Name = "label2";
            label2.Size = new Size(105, 22);
            label2.TabIndex = 8;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(129, 38);
            label1.Name = "label1";
            label1.Size = new Size(74, 22);
            label1.TabIndex = 7;
            label1.Text = "Usuario";
            // 
            // txtContra
            // 
            txtContra.Location = new Point(71, 172);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(195, 23);
            txtContra.TabIndex = 6;
            txtContra.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(71, 73);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(195, 23);
            txtUser.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(101, 14, 2);
            panel1.Location = new Point(-9, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(154, 566);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Diseño_sin_título;
            pictureBox1.Location = new Point(356, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(832, 535);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private GroupBox groupBox1;
        private Button btnIngresar;
        private Label label2;
        private Label label1;
        private TextBox txtContra;
        private TextBox txtUser;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}