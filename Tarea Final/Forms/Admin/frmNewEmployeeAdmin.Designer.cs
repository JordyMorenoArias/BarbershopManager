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
            cmbCedula = new ComboBox();
            label8 = new Label();
            lblBirthDate = new Label();
            lblPhoneNumber = new Label();
            lblEmail = new Label();
            lblName = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            label3 = new Label();
            label6 = new Label();
            cmbPosition = new ComboBox();
            lblSalary = new Label();
            btnContrarar = new Button();
            SuspendLayout();
            // 
            // cmbCedula
            // 
            cmbCedula.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCedula.FormattingEnabled = true;
            cmbCedula.Location = new Point(147, 114);
            cmbCedula.Margin = new Padding(3, 2, 3, 2);
            cmbCedula.Name = "cmbCedula";
            cmbCedula.Size = new Size(274, 30);
            cmbCedula.TabIndex = 154;
            cmbCedula.SelectedIndexChanged += cmbCedula_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(58, 119);
            label8.Name = "label8";
            label8.Size = new Size(86, 25);
            label8.TabIndex = 150;
            label8.Text = "Cedula:";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBirthDate.ForeColor = Color.Silver;
            lblBirthDate.Location = new Point(171, 347);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(102, 24);
            lblBirthDate.TabIndex = 164;
            lblBirthDate.Text = "BirthDate";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhoneNumber.ForeColor = Color.Silver;
            lblPhoneNumber.Location = new Point(157, 285);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(160, 24);
            lblPhoneNumber.TabIndex = 163;
            lblPhoneNumber.Text = "PhoneNumber";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.Silver;
            lblEmail.Location = new Point(126, 226);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 24);
            lblEmail.TabIndex = 161;
            lblEmail.Text = "Email";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.Silver;
            lblName.Location = new Point(147, 171);
            lblName.Name = "lblName";
            lblName.Size = new Size(75, 24);
            lblName.TabIndex = 160;
            lblName.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(62, 347);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 159;
            label5.Text = "Birth Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(58, 285);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 158;
            label4.Text = "Telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(58, 226);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 156;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(58, 170);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 155;
            label1.Text = "Nombre:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Silver;
            label9.Location = new Point(58, 29);
            label9.Name = "label9";
            label9.Size = new Size(287, 33);
            label9.TabIndex = 165;
            label9.Text = "Contratar Empleado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(62, 471);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 166;
            label3.Text = "Salary:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(62, 411);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 167;
            label6.Text = "Position:";
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Items.AddRange(new object[] { "Recepcionista", "Barbero/a" });
            cmbPosition.Location = new Point(161, 406);
            cmbPosition.Margin = new Padding(3, 2, 3, 2);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(205, 30);
            cmbPosition.TabIndex = 168;
            cmbPosition.SelectedIndexChanged += cmbPosition_SelectedIndexChanged;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalary.ForeColor = Color.Silver;
            lblSalary.Location = new Point(147, 471);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(73, 25);
            lblSalary.TabIndex = 169;
            lblSalary.Text = "Salary";
            // 
            // btnContrarar
            // 
            btnContrarar.BackColor = Color.FromArgb(26, 32, 40);
            btnContrarar.FlatAppearance.BorderSize = 0;
            btnContrarar.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnContrarar.FlatStyle = FlatStyle.Flat;
            btnContrarar.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnContrarar.ForeColor = Color.White;
            btnContrarar.ImageAlign = ContentAlignment.MiddleLeft;
            btnContrarar.Location = new Point(638, 466);
            btnContrarar.Margin = new Padding(3, 2, 3, 2);
            btnContrarar.Name = "btnContrarar";
            btnContrarar.Size = new Size(122, 37);
            btnContrarar.TabIndex = 170;
            btnContrarar.Text = "Contratar";
            btnContrarar.UseVisualStyleBackColor = false;
            btnContrarar.Click += btnContratar_Click;
            // 
            // frmNewEmployeeAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 100);
            ClientSize = new Size(839, 554);
            Controls.Add(btnContrarar);
            Controls.Add(lblSalary);
            Controls.Add(cmbPosition);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label9);
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
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmNewEmployeeAdmin";
            Text = "NuevoEmpleado";
            Load += frmNewEmployeeAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbCedula;
        private Label label8;
        private Label lblBirthDate;
        private Label lblPhoneNumber;
        private Label lblEmail;
        private Label lblName;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label9;
        private Label label3;
        private Label label6;
        private ComboBox cmbPosition;
        private Label lblSalary;
        private Button btnContrarar;
    }
}