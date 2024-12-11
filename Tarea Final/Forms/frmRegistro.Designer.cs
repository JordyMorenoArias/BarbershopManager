namespace Tarea_Final
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            panel1 = new Panel();
            btnCerrar = new Button();
            btnRegister = new Button();
            label5 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            txtIdCard = new TextBox();
            label4 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            label6 = new Label();
            txtTelefono = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 38, 70);
            panel1.Controls.Add(btnCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 29);
            panel1.TabIndex = 27;
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
            btnCerrar.Location = new Point(344, 2);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(18, 20);
            btnCerrar.TabIndex = 27;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnRegister
            // 
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(43, 386);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(260, 34);
            btnRegister.TabIndex = 32;
            btnRegister.Text = "Registrarse";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(43, 99);
            label5.Name = "label5";
            label5.Size = new Size(64, 19);
            label5.TabIndex = 83;
            label5.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(43, 120);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(260, 24);
            txtName.TabIndex = 82;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(43, 151);
            label3.Name = "label3";
            label3.Size = new Size(46, 19);
            label3.TabIndex = 81;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(43, 171);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 24);
            txtEmail.TabIndex = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(43, 205);
            label2.Name = "label2";
            label2.Size = new Size(90, 19);
            label2.TabIndex = 79;
            label2.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(43, 226);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(260, 24);
            txtPassword.TabIndex = 78;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(43, 47);
            label1.Name = "label1";
            label1.Size = new Size(61, 19);
            label1.TabIndex = 77;
            label1.Text = "Cédula";
            // 
            // txtIdCard
            // 
            txtIdCard.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdCard.Location = new Point(43, 67);
            txtIdCard.Margin = new Padding(3, 2, 3, 2);
            txtIdCard.Name = "txtIdCard";
            txtIdCard.Size = new Size(260, 24);
            txtIdCard.TabIndex = 76;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(43, 318);
            label4.Name = "label4";
            label4.Size = new Size(160, 19);
            label4.TabIndex = 84;
            label4.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(43, 340);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(260, 23);
            dtpFechaNacimiento.TabIndex = 85;
            dtpFechaNacimiento.Value = new DateTime(2000, 2, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(43, 264);
            label6.Name = "label6";
            label6.Size = new Size(66, 19);
            label6.TabIndex = 87;
            label6.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(43, 285);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(260, 24);
            txtTelefono.TabIndex = 86;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 100);
            ClientSize = new Size(365, 455);
            Controls.Add(label6);
            Controls.Add(txtTelefono);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtIdCard);
            Controls.Add(btnRegister);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmRegistro";
            Text = "Registro";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCerrar;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Button btnRegister;
        private TextBox txtNombre;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox txtName;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtPassword;
        private Label label1;
        private TextBox txtIdCard;
        private Label label4;
        private DateTimePicker dtpFechaNacimiento;
        private Label label6;
        private TextBox txtTelefono;
    }
}