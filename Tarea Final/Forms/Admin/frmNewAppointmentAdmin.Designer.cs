namespace Tarea_Final.Forms.Admin
{
    partial class frmNewAppointmentAdmin
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
            txtDescripcion = new TextBox();
            label3 = new Label();
            lblPrecio = new Label();
            label2 = new Label();
            cmbServicios = new ComboBox();
            label6 = new Label();
            cmbEmpleados = new ComboBox();
            label5 = new Label();
            dtpHora = new DateTimePicker();
            dtpFecha = new DateTimePicker();
            btnCrear = new Button();
            label9 = new Label();
            label7 = new Label();
            cmbCedula = new ComboBox();
            lblName = new Label();
            label4 = new Label();
            label10 = new Label();
            lblPhoneNumber = new Label();
            label8 = new Label();
            lblEmail = new Label();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(461, 311);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.Size = new Size(340, 53);
            txtDescripcion.TabIndex = 103;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(461, 290);
            label3.Name = "label3";
            label3.Size = new Size(89, 19);
            label3.TabIndex = 102;
            label3.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.ForeColor = Color.Silver;
            lblPrecio.Location = new Point(370, 314);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(61, 24);
            lblPrecio.TabIndex = 101;
            lblPrecio.Text = "price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(57, 290);
            label2.Name = "label2";
            label2.Size = new Size(61, 19);
            label2.TabIndex = 100;
            label2.Text = "Servicio";
            // 
            // cmbServicios
            // 
            cmbServicios.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbServicios.FormattingEnabled = true;
            cmbServicios.Location = new Point(57, 311);
            cmbServicios.Margin = new Padding(3, 2, 3, 2);
            cmbServicios.Name = "cmbServicios";
            cmbServicios.Size = new Size(307, 27);
            cmbServicios.TabIndex = 99;
            cmbServicios.SelectedIndexChanged += cmbServicios_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(461, 398);
            label6.Name = "label6";
            label6.Size = new Size(148, 19);
            label6.TabIndex = 98;
            label6.Text = "Barberos disponibles";
            // 
            // cmbEmpleados
            // 
            cmbEmpleados.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEmpleados.FormattingEnabled = true;
            cmbEmpleados.Location = new Point(461, 419);
            cmbEmpleados.Margin = new Padding(3, 2, 3, 2);
            cmbEmpleados.Name = "cmbEmpleados";
            cmbEmpleados.Size = new Size(340, 27);
            cmbEmpleados.TabIndex = 97;
            cmbEmpleados.SelectedIndexChanged += cmbEmpleados_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(58, 399);
            label5.Name = "label5";
            label5.Size = new Size(175, 19);
            label5.TabIndex = 96;
            label5.Text = "Fecha y Hora de la Cita";
            // 
            // dtpHora
            // 
            dtpHora.CalendarFont = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpHora.CustomFormat = "HH:mm";
            dtpHora.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(329, 420);
            dtpHora.Margin = new Padding(3, 2, 3, 2);
            dtpHora.Name = "dtpHora";
            dtpHora.ShowUpDown = true;
            dtpHora.Size = new Size(116, 26);
            dtpHora.TabIndex = 95;
            dtpHora.Value = new DateTime(2024, 8, 13, 8, 0, 0, 0);
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarFont = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFecha.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFecha.Location = new Point(58, 420);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(265, 26);
            dtpFecha.TabIndex = 94;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(26, 32, 40);
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrear.ForeColor = Color.White;
            btnCrear.ImageAlign = ContentAlignment.MiddleLeft;
            btnCrear.Location = new Point(698, 469);
            btnCrear.Margin = new Padding(3, 2, 3, 2);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(103, 33);
            btnCrear.TabIndex = 93;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Silver;
            label9.Location = new Point(59, 50);
            label9.Name = "label9";
            label9.Size = new Size(162, 33);
            label9.TabIndex = 92;
            label9.Text = "Crear Citas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(57, 156);
            label7.Name = "label7";
            label7.Size = new Size(92, 24);
            label7.TabIndex = 106;
            label7.Text = "Cedula:";
            // 
            // cmbCedula
            // 
            cmbCedula.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCedula.FormattingEnabled = true;
            cmbCedula.Location = new Point(157, 156);
            cmbCedula.Margin = new Padding(3, 2, 3, 2);
            cmbCedula.Name = "cmbCedula";
            cmbCedula.Size = new Size(274, 27);
            cmbCedula.TabIndex = 114;
            cmbCedula.SelectedIndexChanged += cmbCedula_SelectedIndexChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.Silver;
            lblName.Location = new Point(609, 159);
            lblName.Name = "lblName";
            lblName.Size = new Size(75, 24);
            lblName.TabIndex = 109;
            lblName.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(504, 224);
            label4.Name = "label4";
            label4.Size = new Size(104, 24);
            label4.TabIndex = 107;
            label4.Text = "Telefono:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Silver;
            label10.Location = new Point(503, 159);
            label10.Name = "label10";
            label10.Size = new Size(100, 24);
            label10.TabIndex = 104;
            label10.Text = "Nombre:";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhoneNumber.ForeColor = Color.Silver;
            lblPhoneNumber.Location = new Point(622, 224);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(160, 24);
            lblPhoneNumber.TabIndex = 112;
            lblPhoneNumber.Text = "PhoneNumber";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(57, 224);
            label8.Name = "label8";
            label8.Size = new Size(69, 24);
            label8.TabIndex = 105;
            label8.Text = "Email:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.Silver;
            lblEmail.Location = new Point(132, 224);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 24);
            lblEmail.TabIndex = 110;
            lblEmail.Text = "Email";
            // 
            // frmNewAppointmentAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 100);
            ClientSize = new Size(839, 554);
            Controls.Add(cmbCedula);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(txtDescripcion);
            Controls.Add(label3);
            Controls.Add(lblPrecio);
            Controls.Add(label2);
            Controls.Add(cmbServicios);
            Controls.Add(label6);
            Controls.Add(cmbEmpleados);
            Controls.Add(label5);
            Controls.Add(dtpHora);
            Controls.Add(dtpFecha);
            Controls.Add(btnCrear);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNewAppointmentAdmin";
            Text = "frmNewAppointmentAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescripcion;
        private Label label3;
        private Label lblPrecio;
        private Label label2;
        private ComboBox cmbServicios;
        private Label label6;
        private ComboBox cmbEmpleados;
        private Label label5;
        private DateTimePicker dtpHora;
        private DateTimePicker dtpFecha;
        private Button btnCrear;
        private Label label9;
        private Label label7;
        private ComboBox cmbCedula;
        private Label lblName;
        private Label label4;
        private Label label10;
        private Label lblPhoneNumber;
        private Label label8;
        private Label lblEmail;
    }
}