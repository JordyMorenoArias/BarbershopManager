namespace Tarea_Final
{
    partial class frmConsultEmployeeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultEmployeeAdmin));
            btnModificar = new Button();
            label9 = new Label();
            lblSalary = new Label();
            cmbPosition = new ComboBox();
            label6 = new Label();
            label3 = new Label();
            lblBirthDate = new Label();
            lblPhoneNumber = new Label();
            lblEmail = new Label();
            lblName = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbCedula = new ComboBox();
            label8 = new Label();
            txtBono = new TextBox();
            label7 = new Label();
            label10 = new Label();
            label11 = new Label();
            lblStatus = new Label();
            btnDepedirOrRecontratar = new Button();
            SuspendLayout();
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
            btnModificar.Location = new Point(651, 469);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(127, 30);
            btnModificar.TabIndex = 77;
            btnModificar.Text = "Update";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Silver;
            label9.Location = new Point(81, 33);
            label9.Name = "label9";
            label9.Size = new Size(293, 33);
            label9.TabIndex = 76;
            label9.Text = "Consultar Empleados";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalary.ForeColor = Color.Silver;
            lblSalary.Location = new Point(166, 469);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(73, 25);
            lblSalary.TabIndex = 183;
            lblSalary.Text = "Salary";
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Items.AddRange(new object[] { "Recepcionista", "Barbero/a" });
            cmbPosition.Location = new Point(185, 404);
            cmbPosition.Margin = new Padding(3, 2, 3, 2);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(273, 30);
            cmbPosition.TabIndex = 182;
            cmbPosition.SelectedIndexChanged += cmbPosition_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(86, 409);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 181;
            label6.Text = "Position:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(86, 469);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 180;
            label3.Text = "Salary:";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBirthDate.ForeColor = Color.Silver;
            lblBirthDate.Location = new Point(195, 345);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(102, 24);
            lblBirthDate.TabIndex = 179;
            lblBirthDate.Text = "BirthDate";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhoneNumber.ForeColor = Color.Silver;
            lblPhoneNumber.Location = new Point(181, 283);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(160, 24);
            lblPhoneNumber.TabIndex = 178;
            lblPhoneNumber.Text = "PhoneNumber";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.Silver;
            lblEmail.Location = new Point(150, 224);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 24);
            lblEmail.TabIndex = 177;
            lblEmail.Text = "Email";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.Silver;
            lblName.Location = new Point(171, 169);
            lblName.Name = "lblName";
            lblName.Size = new Size(75, 24);
            lblName.TabIndex = 176;
            lblName.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(86, 345);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 175;
            label5.Text = "Birth Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(82, 283);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 174;
            label4.Text = "Telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(82, 224);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 173;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(82, 169);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 172;
            label1.Text = "Nombre:";
            // 
            // cmbCedula
            // 
            cmbCedula.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCedula.FormattingEnabled = true;
            cmbCedula.Location = new Point(166, 104);
            cmbCedula.Margin = new Padding(3, 2, 3, 2);
            cmbCedula.Name = "cmbCedula";
            cmbCedula.Size = new Size(292, 30);
            cmbCedula.TabIndex = 171;
            cmbCedula.SelectedIndexChanged += cmbCedula_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(77, 109);
            label8.Name = "label8";
            label8.Size = new Size(86, 25);
            label8.TabIndex = 170;
            label8.Text = "Cedula:";
            // 
            // txtBono
            // 
            txtBono.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBono.Location = new Point(382, 469);
            txtBono.Name = "txtBono";
            txtBono.Size = new Size(78, 27);
            txtBono.TabIndex = 184;
            txtBono.KeyPress += textBox1_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(327, 469);
            label7.Name = "label7";
            label7.Size = new Size(49, 25);
            label7.TabIndex = 185;
            label7.Text = "Ext:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Silver;
            label10.Location = new Point(466, 469);
            label10.Name = "label10";
            label10.Size = new Size(56, 25);
            label10.TabIndex = 186;
            label10.Text = "USD";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Silver;
            label11.Location = new Point(476, 109);
            label11.Name = "label11";
            label11.Size = new Size(79, 25);
            label11.TabIndex = 187;
            label11.Text = "Status:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.Silver;
            lblStatus.Location = new Point(550, 109);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(71, 25);
            lblStatus.TabIndex = 188;
            lblStatus.Text = "Activo";
            // 
            // btnDepedirOrRecontratar
            // 
            btnDepedirOrRecontratar.BackColor = Color.FromArgb(26, 32, 40);
            btnDepedirOrRecontratar.FlatAppearance.BorderSize = 0;
            btnDepedirOrRecontratar.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnDepedirOrRecontratar.FlatStyle = FlatStyle.Flat;
            btnDepedirOrRecontratar.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDepedirOrRecontratar.ForeColor = Color.White;
            btnDepedirOrRecontratar.ImageAlign = ContentAlignment.MiddleLeft;
            btnDepedirOrRecontratar.Location = new Point(651, 104);
            btnDepedirOrRecontratar.Margin = new Padding(3, 2, 3, 2);
            btnDepedirOrRecontratar.Name = "btnDepedirOrRecontratar";
            btnDepedirOrRecontratar.Size = new Size(127, 30);
            btnDepedirOrRecontratar.TabIndex = 189;
            btnDepedirOrRecontratar.Text = "Despedir";
            btnDepedirOrRecontratar.UseVisualStyleBackColor = false;
            btnDepedirOrRecontratar.Click += btnDepedirOrRecontratar_Click;
            // 
            // frmConsultEmployeeAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 100);
            ClientSize = new Size(839, 554);
            Controls.Add(btnDepedirOrRecontratar);
            Controls.Add(lblStatus);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(txtBono);
            Controls.Add(lblSalary);
            Controls.Add(cmbPosition);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(lblBirthDate);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCedula);
            Controls.Add(label8);
            Controls.Add(btnModificar);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmConsultEmployeeAdmin";
            Text = "ConsultarEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnModificar;
        private Label label9;
        private Label label2;
        private TextBox txtCedula;
        private Label lblSalary;
        private ComboBox cmbPosition;
        private Label label6;
        private Label label3;
        private Label lblBirthDate;
        private Label lblPhoneNumber;
        private Label lblEmail;
        private Label lblName;
        private Label label5;
        private Label label4;
        private Label label1;
        private ComboBox cmbCedula;
        private Label label8;
        private TextBox txtBono;
        private Label label7;
        private Label label10;
        private Label label11;
        private Label lblStatus;
        private Button btnDepedirOrRecontratar;
    }
}