namespace Tarea_Final
{
    partial class frmConsulatarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulatarCita));
            label6 = new Label();
            cmbBarberos = new ComboBox();
            label5 = new Label();
            dtpHora = new DateTimePicker();
            dtpFecha = new DateTimePicker();
            btnBuscar = new Button();
            txtcedula = new TextBox();
            label10 = new Label();
            btnCerrar = new Button();
            btnModificar = new Button();
            label9 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtCorreo = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            label7 = new Label();
            cmbStatus = new ComboBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(329, 148);
            label6.Name = "label6";
            label6.Size = new Size(68, 19);
            label6.TabIndex = 105;
            label6.Text = "Barberos";
            // 
            // cmbBarberos
            // 
            cmbBarberos.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBarberos.FormattingEnabled = true;
            cmbBarberos.Location = new Point(329, 167);
            cmbBarberos.Margin = new Padding(3, 2, 3, 2);
            cmbBarberos.Name = "cmbBarberos";
            cmbBarberos.Size = new Size(274, 27);
            cmbBarberos.TabIndex = 104;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(50, 374);
            label5.Name = "label5";
            label5.Size = new Size(175, 19);
            label5.TabIndex = 103;
            label5.Text = "Fecha y Hora de la Cita";
            // 
            // dtpHora
            // 
            dtpHora.CalendarFont = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(228, 392);
            dtpHora.Margin = new Padding(3, 2, 3, 2);
            dtpHora.Name = "dtpHora";
            dtpHora.ShowUpDown = true;
            dtpHora.Size = new Size(96, 23);
            dtpHora.TabIndex = 102;
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarFont = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(50, 392);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(174, 23);
            dtpFecha.TabIndex = 101;
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
            btnBuscar.Location = new Point(485, 117);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(118, 24);
            btnBuscar.TabIndex = 100;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtcedula
            // 
            txtcedula.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtcedula.Location = new Point(49, 117);
            txtcedula.Margin = new Padding(3, 2, 3, 2);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(430, 24);
            txtcedula.TabIndex = 99;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Silver;
            label10.Location = new Point(49, 100);
            label10.Name = "label10";
            label10.Size = new Size(61, 19);
            label10.TabIndex = 98;
            label10.Text = "Cedula";
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
            btnCerrar.Location = new Point(469, 392);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(134, 23);
            btnCerrar.TabIndex = 97;
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
            btnModificar.Location = new Point(330, 391);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(135, 24);
            btnModificar.TabIndex = 96;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Silver;
            label9.Location = new Point(49, 47);
            label9.Name = "label9";
            label9.Size = new Size(212, 33);
            label9.TabIndex = 95;
            label9.Text = "Consultar Citas";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(50, 334);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.Size = new Size(274, 24);
            txtTelefono.TabIndex = 94;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(50, 318);
            label4.Name = "label4";
            label4.Size = new Size(66, 19);
            label4.TabIndex = 93;
            label4.Text = "Telefono";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(49, 277);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.ReadOnly = true;
            txtCorreo.Size = new Size(275, 24);
            txtCorreo.TabIndex = 92;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(49, 260);
            label3.Name = "label3";
            label3.Size = new Size(55, 19);
            label3.TabIndex = 91;
            label3.Text = "Correo";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(49, 227);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(275, 24);
            txtApellido.TabIndex = 90;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(49, 209);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 89;
            label2.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(49, 169);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(275, 24);
            txtNombre.TabIndex = 88;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(49, 153);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 87;
            label1.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(330, 205);
            label7.Name = "label7";
            label7.Size = new Size(106, 19);
            label7.TabIndex = 111;
            label7.Text = "Status de Cita";
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Cancelada", "Pendiente", "Cumplida" });
            cmbStatus.Location = new Point(330, 226);
            cmbStatus.Margin = new Padding(3, 2, 3, 2);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(274, 27);
            cmbStatus.TabIndex = 110;
            // 
            // ConsulatarCita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 100);
            ClientSize = new Size(654, 498);
            Controls.Add(label7);
            Controls.Add(cmbStatus);
            Controls.Add(label6);
            Controls.Add(cmbBarberos);
            Controls.Add(label5);
            Controls.Add(dtpHora);
            Controls.Add(dtpFecha);
            Controls.Add(btnBuscar);
            Controls.Add(txtcedula);
            Controls.Add(label10);
            Controls.Add(btnCerrar);
            Controls.Add(btnModificar);
            Controls.Add(label9);
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
            Name = "ConsulatarCita";
            Text = "ConsulatarCita";
            Load += ConsulatarCita_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private ComboBox cmbBarberos;
        private Label label5;
        private DateTimePicker dtpHora;
        private DateTimePicker dtpFecha;
        private Button btnBuscar;
        private TextBox txtcedula;
        private Label label10;
        private Button btnCerrar;
        private Button btnModificar;
        private Label label9;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtCorreo;
        private Label label3;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Label label7;
        private ComboBox cmbStatus;
    }
}