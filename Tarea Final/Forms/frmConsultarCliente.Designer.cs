namespace Tarea_Final
{
    partial class frmConsultarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarCliente));
            btnCerrar = new Button();
            btnModificar = new Button();
            label9 = new Label();
            cmbSexo = new ComboBox();
            dtmNacimiento = new DateTimePicker();
            txtEdad = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtCorreo = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            txtcedula = new TextBox();
            label10 = new Label();
            btnBuscar = new Button();
            SuspendLayout();
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
            btnCerrar.Location = new Point(485, 388);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(125, 25);
            btnCerrar.TabIndex = 57;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(26, 32, 40);
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(359, 388);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(121, 25);
            btnModificar.TabIndex = 56;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Silver;
            label9.Location = new Point(97, 89);
            label9.Name = "label9";
            label9.Size = new Size(252, 33);
            label9.TabIndex = 55;
            label9.Text = "Consultar Clientes";
            // 
            // cmbSexo
            // 
            cmbSexo.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cmbSexo.Location = new Point(359, 278);
            cmbSexo.Margin = new Padding(3, 2, 3, 2);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(252, 27);
            cmbSexo.TabIndex = 54;
            // 
            // dtmNacimiento
            // 
            dtmNacimiento.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtmNacimiento.Format = DateTimePickerFormat.Custom;
            dtmNacimiento.Location = new Point(359, 225);
            dtmNacimiento.Margin = new Padding(3, 2, 3, 2);
            dtmNacimiento.Name = "dtmNacimiento";
            dtmNacimiento.Size = new Size(252, 24);
            dtmNacimiento.TabIndex = 53;
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEdad.Location = new Point(359, 334);
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
            label7.Location = new Point(359, 317);
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
            label6.Location = new Point(359, 260);
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
            label5.Location = new Point(359, 207);
            label5.Name = "label5";
            label5.Size = new Size(160, 19);
            label5.TabIndex = 47;
            label5.Text = "Fecha de Nacimiento";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(97, 391);
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
            label4.Location = new Point(97, 374);
            label4.Name = "label4";
            label4.Size = new Size(66, 19);
            label4.TabIndex = 45;
            label4.Text = "Telefono";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(97, 334);
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
            label3.Location = new Point(97, 317);
            label3.Name = "label3";
            label3.Size = new Size(55, 19);
            label3.TabIndex = 43;
            label3.Text = "Correo";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(97, 278);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(252, 24);
            txtApellido.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(97, 260);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 41;
            label2.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(97, 224);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(252, 24);
            txtNombre.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(97, 207);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 39;
            label1.Text = "Nombre";
            // 
            // txtcedula
            // 
            txtcedula.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtcedula.Location = new Point(97, 160);
            txtcedula.Margin = new Padding(3, 2, 3, 2);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(383, 24);
            txtcedula.TabIndex = 60;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Silver;
            label10.Location = new Point(97, 142);
            label10.Name = "label10";
            label10.Size = new Size(61, 19);
            label10.TabIndex = 59;
            label10.Text = "Cedula";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(26, 32, 40);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(485, 160);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(125, 25);
            btnBuscar.TabIndex = 61;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // ConsultarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 100);
            ClientSize = new Size(704, 500);
            Controls.Add(btnBuscar);
            Controls.Add(txtcedula);
            Controls.Add(label10);
            Controls.Add(btnCerrar);
            Controls.Add(btnModificar);
            Controls.Add(label9);
            Controls.Add(cmbSexo);
            Controls.Add(dtmNacimiento);
            Controls.Add(txtEdad);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(txtCorreo);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "ConsultarCliente";
            Text = "ConsultarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCerrar;
        private Button btnModificar;
        private Label label9;
        private ComboBox cmbSexo;
        private DateTimePicker dtmNacimiento;
        private TextBox txtEdad;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtCorreo;
        private Label label3;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtcedula;
        private Label label10;
        private Button btnBuscar;
    }
}