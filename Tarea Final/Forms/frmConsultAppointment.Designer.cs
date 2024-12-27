namespace Tarea_Final
{
    partial class frmConsultAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultAppointment));
            btnCerrar = new Button();
            btnModificar = new Button();
            label9 = new Label();
            label7 = new Label();
            cmbStatus = new ComboBox();
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
            dgvCitas = new DataGridView();
            dvgColumnId = new DataGridViewTextBoxColumn();
            dvgColumnService = new DataGridViewTextBoxColumn();
            dvgColumnPrice = new DataGridViewTextBoxColumn();
            dvgColumnDate = new DataGridViewTextBoxColumn();
            dvgColumnHour = new DataGridViewTextBoxColumn();
            dvgColumnEmployee = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
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
            btnCerrar.Location = new Point(540, 449);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(93, 27);
            btnCerrar.TabIndex = 97;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(26, 32, 40);
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(440, 449);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 27);
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
            label9.Location = new Point(28, 43);
            label9.Name = "label9";
            label9.Size = new Size(212, 33);
            label9.TabIndex = 95;
            label9.Text = "Consultar Citas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(512, 184);
            label7.Name = "label7";
            label7.Size = new Size(106, 19);
            label7.TabIndex = 111;
            label7.Text = "Status de Cita";
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Cancelar", "Pendiente" });
            cmbStatus.Location = new Point(512, 206);
            cmbStatus.Margin = new Padding(3, 2, 3, 2);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 27);
            cmbStatus.TabIndex = 110;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(37, 182);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.Size = new Size(293, 51);
            txtDescripcion.TabIndex = 121;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(37, 161);
            label3.Name = "label3";
            label3.Size = new Size(89, 19);
            label3.TabIndex = 120;
            label3.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.ForeColor = Color.Silver;
            lblPrecio.Location = new Point(252, 124);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(61, 24);
            lblPrecio.TabIndex = 119;
            lblPrecio.Text = "price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(37, 100);
            label2.Name = "label2";
            label2.Size = new Size(61, 19);
            label2.TabIndex = 118;
            label2.Text = "Servicio";
            // 
            // cmbServicios
            // 
            cmbServicios.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbServicios.FormattingEnabled = true;
            cmbServicios.Location = new Point(37, 121);
            cmbServicios.Margin = new Padding(3, 2, 3, 2);
            cmbServicios.Name = "cmbServicios";
            cmbServicios.Size = new Size(209, 27);
            cmbServicios.TabIndex = 117;
            cmbServicios.SelectedIndexChanged += cmbServicios_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(336, 184);
            label6.Name = "label6";
            label6.Size = new Size(148, 19);
            label6.TabIndex = 116;
            label6.Text = "Barberos disponibles";
            // 
            // cmbEmpleados
            // 
            cmbEmpleados.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEmpleados.FormattingEnabled = true;
            cmbEmpleados.Location = new Point(336, 206);
            cmbEmpleados.Margin = new Padding(3, 2, 3, 2);
            cmbEmpleados.Name = "cmbEmpleados";
            cmbEmpleados.Size = new Size(170, 27);
            cmbEmpleados.TabIndex = 115;
            cmbEmpleados.SelectedIndexChanged += cmbEmpleados_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(336, 101);
            label5.Name = "label5";
            label5.Size = new Size(175, 19);
            label5.TabIndex = 114;
            label5.Text = "Fecha y Hora de la Cita";
            // 
            // dtpHora
            // 
            dtpHora.CalendarFont = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpHora.CustomFormat = "HH:mm";
            dtpHora.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(512, 122);
            dtpHora.Margin = new Padding(3, 2, 3, 2);
            dtpHora.Name = "dtpHora";
            dtpHora.ShowUpDown = true;
            dtpHora.Size = new Size(121, 26);
            dtpHora.TabIndex = 113;
            dtpHora.Value = new DateTime(2024, 12, 13, 8, 0, 0, 0);
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarFont = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFecha.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(336, 122);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(170, 26);
            dtpFecha.TabIndex = 112;
            dtpFecha.Value = new DateTime(2024, 12, 13, 0, 0, 0, 0);
            // 
            // dgvCitas
            // 
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Columns.AddRange(new DataGridViewColumn[] { dvgColumnId, dvgColumnService, dvgColumnPrice, dvgColumnDate, dvgColumnHour, dvgColumnEmployee });
            dgvCitas.Location = new Point(37, 254);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dgvCitas.RowHeadersVisible = false;
            dgvCitas.RowTemplate.Height = 25;
            dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCitas.Size = new Size(596, 181);
            dgvCitas.TabIndex = 122;
            dgvCitas.CellContentClick += dgvCitas_CellContentClick;
            dgvCitas.CellContentDoubleClick += dgvCitas_CellContentDoubleClick;
            // 
            // dvgColumnId
            // 
            dvgColumnId.HeaderText = "Id";
            dvgColumnId.Name = "dvgColumnId";
            dvgColumnId.ReadOnly = true;
            dvgColumnId.Visible = false;
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
            // frmConsultAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 100);
            ClientSize = new Size(654, 498);
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
            Controls.Add(btnCerrar);
            Controls.Add(btnModificar);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmConsultAppointment";
            Text = "ConsulatarCita";
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCerrar;
        private Button btnModificar;
        private Label label9;
        private Label label7;
        private ComboBox cmbStatus;
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
        private DataGridView dgvCitas;
        private DataGridViewTextBoxColumn dvgColumnId;
        private DataGridViewTextBoxColumn dvgColumnService;
        private DataGridViewTextBoxColumn dvgColumnPrice;
        private DataGridViewTextBoxColumn dvgColumnDate;
        private DataGridViewTextBoxColumn dvgColumnHour;
        private DataGridViewTextBoxColumn dvgColumnEmployee;
    }
}