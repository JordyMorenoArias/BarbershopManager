namespace Tarea_Final.Forms
{
    partial class frmConsultAppointmentAdmin
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
            dgvCitas = new DataGridView();
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
            label7 = new Label();
            cmbStatus = new ComboBox();
            btnModificar = new Button();
            label9 = new Label();
            label1 = new Label();
            cmbCedula = new ComboBox();
            lblEmail = new Label();
            lblName = new Label();
            label4 = new Label();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            lblPhoneNumber = new Label();
            dvgColumnId = new DataGridViewTextBoxColumn();
            ColumnIdUser = new DataGridViewTextBoxColumn();
            dvgColumnService = new DataGridViewTextBoxColumn();
            dvgColumnPrice = new DataGridViewTextBoxColumn();
            dvgColumnDate = new DataGridViewTextBoxColumn();
            dvgColumnHour = new DataGridViewTextBoxColumn();
            dvgColumnEmployee = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // dgvCitas
            // 
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Columns.AddRange(new DataGridViewColumn[] { dvgColumnId, ColumnIdUser, dvgColumnService, dvgColumnPrice, dvgColumnDate, dvgColumnHour, dvgColumnEmployee });
            dgvCitas.Location = new Point(31, 269);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dgvCitas.RowHeadersVisible = false;
            dgvCitas.RowTemplate.Height = 25;
            dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCitas.Size = new Size(598, 252);
            dgvCitas.TabIndex = 138;
            dgvCitas.CellContentClick += dgvCitas_CellContentClick;
            dgvCitas.CellContentDoubleClick += dgvCitas_CellContentDoubleClick;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(512, 170);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.Size = new Size(293, 62);
            txtDescripcion.TabIndex = 137;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(512, 146);
            label3.Name = "label3";
            label3.Size = new Size(89, 19);
            label3.TabIndex = 136;
            label3.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.ForeColor = Color.Silver;
            lblPrecio.Location = new Point(744, 98);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(61, 24);
            lblPrecio.TabIndex = 135;
            lblPrecio.Text = "price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(512, 74);
            label2.Name = "label2";
            label2.Size = new Size(61, 19);
            label2.TabIndex = 134;
            label2.Text = "Servicio";
            // 
            // cmbServicios
            // 
            cmbServicios.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbServicios.FormattingEnabled = true;
            cmbServicios.Location = new Point(512, 95);
            cmbServicios.Margin = new Padding(3, 2, 3, 2);
            cmbServicios.Name = "cmbServicios";
            cmbServicios.Size = new Size(226, 27);
            cmbServicios.TabIndex = 133;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(644, 365);
            label6.Name = "label6";
            label6.Size = new Size(148, 19);
            label6.TabIndex = 132;
            label6.Text = "Barberos disponibles";
            // 
            // cmbEmpleados
            // 
            cmbEmpleados.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEmpleados.FormattingEnabled = true;
            cmbEmpleados.Location = new Point(644, 386);
            cmbEmpleados.Margin = new Padding(3, 2, 3, 2);
            cmbEmpleados.Name = "cmbEmpleados";
            cmbEmpleados.Size = new Size(161, 27);
            cmbEmpleados.TabIndex = 131;
            cmbEmpleados.SelectedIndexChanged += cmbEmpleados_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(644, 248);
            label5.Name = "label5";
            label5.Size = new Size(86, 19);
            label5.TabIndex = 130;
            label5.Text = "Fecha Cita";
            // 
            // dtpHora
            // 
            dtpHora.CalendarFont = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpHora.CustomFormat = "HH:mm";
            dtpHora.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(644, 328);
            dtpHora.Margin = new Padding(3, 2, 3, 2);
            dtpHora.Name = "dtpHora";
            dtpHora.ShowUpDown = true;
            dtpHora.Size = new Size(161, 26);
            dtpHora.TabIndex = 129;
            dtpHora.Value = new DateTime(2024, 12, 13, 8, 0, 0, 0);
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarFont = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFecha.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(644, 269);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(161, 26);
            dtpFecha.TabIndex = 128;
            dtpFecha.Value = new DateTime(2024, 12, 13, 0, 0, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(644, 422);
            label7.Name = "label7";
            label7.Size = new Size(106, 19);
            label7.TabIndex = 127;
            label7.Text = "Status de Cita";
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Cancelar", "Pendiente" });
            cmbStatus.Location = new Point(644, 444);
            cmbStatus.Margin = new Padding(3, 2, 3, 2);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(161, 27);
            cmbStatus.TabIndex = 126;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(26, 32, 40);
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(644, 488);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(161, 33);
            btnModificar.TabIndex = 124;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Silver;
            label9.Location = new Point(30, 23);
            label9.Name = "label9";
            label9.Size = new Size(212, 33);
            label9.TabIndex = 123;
            label9.Text = "Consultar Citas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(644, 307);
            label1.Name = "label1";
            label1.Size = new Size(75, 19);
            label1.TabIndex = 139;
            label1.Text = "Hora Cita";
            // 
            // cmbCedula
            // 
            cmbCedula.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCedula.FormattingEnabled = true;
            cmbCedula.Items.AddRange(new object[] { "All" });
            cmbCedula.Location = new Point(119, 92);
            cmbCedula.Margin = new Padding(3, 2, 3, 2);
            cmbCedula.Name = "cmbCedula";
            cmbCedula.Size = new Size(274, 30);
            cmbCedula.TabIndex = 146;
            cmbCedula.Tag = "";
            cmbCedula.Text = "All";
            cmbCedula.SelectedIndexChanged += cmbCedula_SelectedIndexChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.Silver;
            lblEmail.Location = new Point(105, 191);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(56, 22);
            lblEmail.TabIndex = 145;
            lblEmail.Text = "Email";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.Silver;
            lblName.Location = new Point(116, 146);
            lblName.Name = "lblName";
            lblName.Size = new Size(66, 22);
            lblName.TabIndex = 144;
            lblName.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(30, 236);
            label4.Name = "label4";
            label4.Size = new Size(92, 22);
            label4.TabIndex = 143;
            label4.Text = "Telefono:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(30, 100);
            label8.Name = "label8";
            label8.Size = new Size(83, 22);
            label8.TabIndex = 142;
            label8.Text = "Cedula:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Silver;
            label10.Location = new Point(30, 191);
            label10.Name = "label10";
            label10.Size = new Size(61, 22);
            label10.TabIndex = 141;
            label10.Text = "Email:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Silver;
            label11.Location = new Point(30, 146);
            label11.Name = "label11";
            label11.Size = new Size(89, 22);
            label11.TabIndex = 140;
            label11.Text = "Nombre:";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhoneNumber.ForeColor = Color.Silver;
            lblPhoneNumber.Location = new Point(116, 236);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(143, 22);
            lblPhoneNumber.TabIndex = 147;
            lblPhoneNumber.Text = "PhoneNumber";
            // 
            // dvgColumnId
            // 
            dvgColumnId.HeaderText = "Id";
            dvgColumnId.Name = "dvgColumnId";
            dvgColumnId.ReadOnly = true;
            dvgColumnId.Visible = false;
            // 
            // ColumnIdUser
            // 
            ColumnIdUser.HeaderText = "Id Usuario";
            ColumnIdUser.Name = "ColumnIdUser";
            ColumnIdUser.ReadOnly = true;
            // 
            // dvgColumnService
            // 
            dvgColumnService.HeaderText = "Service";
            dvgColumnService.Name = "dvgColumnService";
            dvgColumnService.ReadOnly = true;
            // 
            // dvgColumnPrice
            // 
            dvgColumnPrice.HeaderText = "Price";
            dvgColumnPrice.Name = "dvgColumnPrice";
            dvgColumnPrice.ReadOnly = true;
            // 
            // dvgColumnDate
            // 
            dvgColumnDate.HeaderText = "Date";
            dvgColumnDate.Name = "dvgColumnDate";
            dvgColumnDate.ReadOnly = true;
            // 
            // dvgColumnHour
            // 
            dvgColumnHour.HeaderText = "Hour";
            dvgColumnHour.Name = "dvgColumnHour";
            dvgColumnHour.ReadOnly = true;
            // 
            // dvgColumnEmployee
            // 
            dvgColumnEmployee.HeaderText = "Barber";
            dvgColumnEmployee.Name = "dvgColumnEmployee";
            dvgColumnEmployee.ReadOnly = true;
            // 
            // frmConsultAppointmentAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 100);
            ClientSize = new Size(839, 554);
            Controls.Add(lblPhoneNumber);
            Controls.Add(cmbCedula);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label1);
            Controls.Add(dgvCitas);
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
            Controls.Add(label7);
            Controls.Add(cmbStatus);
            Controls.Add(btnModificar);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmConsultAppointmentAdmin";
            Text = "frmConsultAppointmentAdmin";
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCitas;
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
        private Label label7;
        private ComboBox cmbStatus;
        private Button btnModificar;
        private Label label9;
        private Label label1;
        private ComboBox cmbCedula;
        private Label lblEmail;
        private Label lblName;
        private Label label4;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label lblPhoneNumber;
        private DataGridViewTextBoxColumn dvgColumnId;
        private DataGridViewTextBoxColumn ColumnIdUser;
        private DataGridViewTextBoxColumn dvgColumnService;
        private DataGridViewTextBoxColumn dvgColumnPrice;
        private DataGridViewTextBoxColumn dvgColumnDate;
        private DataGridViewTextBoxColumn dvgColumnHour;
        private DataGridViewTextBoxColumn dvgColumnEmployee;
    }
}