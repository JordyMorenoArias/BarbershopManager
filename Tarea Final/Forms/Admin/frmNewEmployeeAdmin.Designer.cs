namespace Tarea_Final
{
    partial class frmNewEmployeeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewEmployeeAdmin));
            btnNuevo = new Button();
            btnCerrar = new Button();
            btnGuardar = new Button();
            label9 = new Label();
            cmbSexo = new ComboBox();
            dtmNacimiento = new DateTimePicker();
            txtcedula = new TextBox();
            label8 = new Label();
            txtEdad = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtCorreo = new TextBox();
            label3 = new Label();
            txtNombreCompleto = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(26, 32, 40);
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(330, 343);
            btnNuevo.Margin = new Padding(3, 2, 3, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(82, 25);
            btnNuevo.TabIndex = 58;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(26, 32, 40);
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.Location = new Point(499, 343);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(82, 25);
            btnCerrar.TabIndex = 57;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(26, 32, 40);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(415, 343);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 25);
            btnGuardar.TabIndex = 56;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Silver;
            label9.Location = new Point(46, 61);
            label9.Name = "label9";
            label9.Size = new Size(248, 33);
            label9.TabIndex = 55;
            label9.Text = "Nuevo Empleado";
            // 
            // cmbSexo
            // 
            cmbSexo.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cmbSexo.Location = new Point(330, 218);
            cmbSexo.Margin = new Padding(3, 2, 3, 2);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(252, 27);
            cmbSexo.TabIndex = 54;
            // 
            // dtmNacimiento
            // 
            dtmNacimiento.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtmNacimiento.Format = DateTimePickerFormat.Custom;
            dtmNacimiento.Location = new Point(330, 156);
            dtmNacimiento.Margin = new Padding(3, 2, 3, 2);
            dtmNacimiento.Name = "dtmNacimiento";
            dtmNacimiento.Size = new Size(252, 24);
            dtmNacimiento.TabIndex = 53;
            // 
            // txtcedula
            // 
            txtcedula.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtcedula.Location = new Point(55, 156);
            txtcedula.Margin = new Padding(3, 2, 3, 2);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(252, 24);
            txtcedula.TabIndex = 52;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(55, 139);
            label8.Name = "label8";
            label8.Size = new Size(61, 19);
            label8.TabIndex = 51;
            label8.Text = "Cedula";
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEdad.Location = new Point(330, 281);
            txtEdad.Margin = new Padding(3, 2, 3, 2);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(252, 24);
            txtEdad.TabIndex = 50;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(330, 264);
            label7.Name = "label7";
            label7.Size = new Size(47, 19);
            label7.TabIndex = 49;
            label7.Text = "Edad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(330, 200);
            label6.Name = "label6";
            label6.Size = new Size(41, 19);
            label6.TabIndex = 48;
            label6.Text = "Sexo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(330, 136);
            label5.Name = "label5";
            label5.Size = new Size(160, 19);
            label5.TabIndex = 47;
            label5.Text = "Fecha de Nacimiento";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(55, 345);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(252, 24);
            txtTelefono.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(55, 328);
            label4.Name = "label4";
            label4.Size = new Size(66, 19);
            label4.TabIndex = 45;
            label4.Text = "Telefono";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(55, 281);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(252, 24);
            txtCorreo.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(55, 264);
            label3.Name = "label3";
            label3.Size = new Size(55, 19);
            label3.TabIndex = 43;
            label3.Text = "Correo";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreCompleto.Location = new Point(55, 218);
            txtNombreCompleto.Margin = new Padding(3, 2, 3, 2);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(252, 24);
            txtNombreCompleto.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(55, 201);
            label1.Name = "label1";
            label1.Size = new Size(137, 19);
            label1.TabIndex = 39;
            label1.Text = "Nombre Completo";
            // 
            // NuevoEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 100);
            ClientSize = new Size(654, 498);
            Controls.Add(btnNuevo);
            Controls.Add(btnCerrar);
            Controls.Add(btnGuardar);
            Controls.Add(label9);
            Controls.Add(cmbSexo);
            Controls.Add(dtmNacimiento);
            Controls.Add(txtcedula);
            Controls.Add(label8);
            Controls.Add(txtEdad);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(txtCorreo);
            Controls.Add(label3);
            Controls.Add(txtNombreCompleto);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "NuevoEmpleado";
            Text = "NuevoEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private Button btnCerrar;
        private Button btnGuardar;
        private Label label9;
        private ComboBox cmbSexo;
        private DateTimePicker dtmNacimiento;
        private TextBox txtcedula;
        private Label label8;
        private TextBox txtEdad;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtCorreo;
        private Label label3;
        private TextBox txtNombreCompleto;
        private Label label1;
    }
}