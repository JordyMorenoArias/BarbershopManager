namespace Tarea_Final
{
    partial class frmConsultUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultUser));
            label6 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            label1 = new Label();
            txtIdCard = new TextBox();
            btnCerrar = new Button();
            btnModificar = new Button();
            label2 = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(72, 261);
            label6.Name = "label6";
            label6.Size = new Size(87, 22);
            label6.TabIndex = 99;
            label6.Text = "Telefono";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaNacimiento.Location = new Point(74, 365);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(285, 27);
            dtpFechaNacimiento.TabIndex = 97;
            dtpFechaNacimiento.Value = new DateTime(2000, 2, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(72, 330);
            label4.Name = "label4";
            label4.Size = new Size(208, 22);
            label4.TabIndex = 96;
            label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(66, 125);
            label5.Name = "label5";
            label5.Size = new Size(84, 22);
            label5.TabIndex = 95;
            label5.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(72, 149);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(285, 27);
            txtName.TabIndex = 94;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(72, 191);
            label3.Name = "label3";
            label3.Size = new Size(56, 22);
            label3.TabIndex = 93;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(72, 215);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(285, 27);
            txtEmail.TabIndex = 92;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhoneNumber.Location = new Point(74, 285);
            txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(285, 27);
            txtPhoneNumber.TabIndex = 90;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(72, 58);
            label1.Name = "label1";
            label1.Size = new Size(78, 22);
            label1.TabIndex = 89;
            label1.Text = "Cédula";
            // 
            // txtIdCard
            // 
            txtIdCard.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdCard.Location = new Point(72, 82);
            txtIdCard.Margin = new Padding(3, 2, 3, 2);
            txtIdCard.Name = "txtIdCard";
            txtIdCard.Size = new Size(285, 27);
            txtIdCard.TabIndex = 88;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(26, 32, 40);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.Location = new Point(535, 422);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(105, 27);
            btnCerrar.TabIndex = 101;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(26, 32, 40);
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.Enabled = false;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(424, 422);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(105, 27);
            btnModificar.TabIndex = 100;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(396, 330);
            label2.Name = "label2";
            label2.Size = new Size(213, 22);
            label2.TabIndex = 103;
            label2.Text = "Ingresa tu contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(396, 365);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(244, 27);
            txtPassword.TabIndex = 102;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // frmConsultUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 100);
            ClientSize = new Size(704, 500);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(btnCerrar);
            Controls.Add(btnModificar);
            Controls.Add(label6);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label1);
            Controls.Add(txtIdCard);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmConsultUser";
            Text = "ConsultarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private DateTimePicker dtpFechaNacimiento;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private Label label1;
        private TextBox txtIdCard;
        private Button btnCerrar;
        private Button btnModificar;
        private Label label2;
        private TextBox txtPassword;
    }
}