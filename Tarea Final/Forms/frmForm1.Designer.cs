namespace Tarea_Final
{
    partial class frmIniciarSeccion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIniciarSeccion));
            lbRegistro = new LinkLabel();
            pictureBox1 = new PictureBox();
            cbMostras = new CheckBox();
            label2 = new Label();
            txtContraseña = new TextBox();
            label1 = new Label();
            btnIniciar = new Button();
            txtEmail = new TextBox();
            panel1 = new Panel();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbRegistro
            // 
            lbRegistro.AutoSize = true;
            lbRegistro.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbRegistro.LinkColor = Color.Silver;
            lbRegistro.Location = new Point(127, 426);
            lbRegistro.Name = "lbRegistro";
            lbRegistro.Size = new Size(95, 20);
            lbRegistro.TabIndex = 25;
            lbRegistro.TabStop = true;
            lbRegistro.Text = "Registrarme";
            lbRegistro.LinkClicked += lbRegistro_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(100, 57);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // cbMostras
            // 
            cbMostras.AutoSize = true;
            cbMostras.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbMostras.ForeColor = Color.Silver;
            cbMostras.Location = new Point(60, 332);
            cbMostras.Margin = new Padding(3, 2, 3, 2);
            cbMostras.Name = "cbMostras";
            cbMostras.Size = new Size(84, 24);
            cbMostras.TabIndex = 23;
            cbMostras.Text = "Mostrar";
            cbMostras.UseVisualStyleBackColor = true;
            cbMostras.CheckedChanged += cbMostras_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(60, 268);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 22;
            label2.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(60, 294);
            txtContraseña.Margin = new Padding(3, 2, 3, 2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(244, 27);
            txtContraseña.TabIndex = 21;
            txtContraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(60, 195);
            label1.Name = "label1";
            label1.Size = new Size(51, 21);
            label1.TabIndex = 20;
            label1.Text = "Email";
            // 
            // btnIniciar
            // 
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(60, 375);
            btnIniciar.Margin = new Padding(3, 2, 3, 2);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(243, 34);
            btnIniciar.TabIndex = 19;
            btnIniciar.Text = "INICIAR";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(60, 220);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(244, 27);
            txtEmail.TabIndex = 18;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 38, 70);
            panel1.Controls.Add(btnCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 29);
            panel1.TabIndex = 26;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(340, 2);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(18, 20);
            btnCerrar.TabIndex = 27;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmIniciarSeccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 100);
            ClientSize = new Size(368, 469);
            Controls.Add(panel1);
            Controls.Add(lbRegistro);
            Controls.Add(pictureBox1);
            Controls.Add(cbMostras);
            Controls.Add(label2);
            Controls.Add(txtContraseña);
            Controls.Add(label1);
            Controls.Add(btnIniciar);
            Controls.Add(txtEmail);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmIniciarSeccion";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lbRegistro;
        private PictureBox pictureBox1;
        private CheckBox cbMostras;
        private Label label2;
        private TextBox txtContraseña;
        private Label label1;
        private Button btnIniciar;
        private TextBox txtEmail;
        private Panel panel1;
        private Button btnCerrar;
    }
}