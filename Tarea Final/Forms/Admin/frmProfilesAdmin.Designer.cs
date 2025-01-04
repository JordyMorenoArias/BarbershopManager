namespace Tarea_Final.Forms.Admin
{
    partial class frmProfilesAdmin
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
            lblBirthDate = new Label();
            lblPhoneNumber = new Label();
            lblEmail = new Label();
            lblName = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            cmbCedula = new ComboBox();
            SuspendLayout();
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBirthDate.ForeColor = Color.Silver;
            lblBirthDate.Location = new Point(199, 435);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(102, 24);
            lblBirthDate.TabIndex = 70;
            lblBirthDate.Text = "BirthDate";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhoneNumber.ForeColor = Color.Silver;
            lblPhoneNumber.Location = new Point(190, 364);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(160, 24);
            lblPhoneNumber.TabIndex = 69;
            lblPhoneNumber.Text = "PhoneNumber";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.Silver;
            lblEmail.Location = new Point(149, 288);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 24);
            lblEmail.TabIndex = 67;
            lblEmail.Text = "Email";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.Silver;
            lblName.Location = new Point(186, 225);
            lblName.Name = "lblName";
            lblName.Size = new Size(75, 24);
            lblName.TabIndex = 66;
            lblName.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(58, 427);
            label5.Name = "label5";
            label5.Size = new Size(135, 30);
            label5.TabIndex = 65;
            label5.Text = "Birth Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(58, 356);
            label4.Name = "label4";
            label4.Size = new Size(124, 30);
            label4.TabIndex = 64;
            label4.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(58, 152);
            label3.Name = "label3";
            label3.Size = new Size(109, 30);
            label3.TabIndex = 63;
            label3.Text = "Cedula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(58, 281);
            label2.Name = "label2";
            label2.Size = new Size(85, 30);
            label2.TabIndex = 62;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(58, 217);
            label1.Name = "label1";
            label1.Size = new Size(117, 30);
            label1.TabIndex = 61;
            label1.Text = "Nombre:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Silver;
            label9.Location = new Point(55, 55);
            label9.Name = "label9";
            label9.Size = new Size(77, 33);
            label9.TabIndex = 60;
            label9.Text = "Perfil";
            // 
            // cmbCedula
            // 
            cmbCedula.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCedula.FormattingEnabled = true;
            cmbCedula.Location = new Point(173, 152);
            cmbCedula.Margin = new Padding(3, 2, 3, 2);
            cmbCedula.Name = "cmbCedula";
            cmbCedula.Size = new Size(273, 30);
            cmbCedula.TabIndex = 172;
            cmbCedula.SelectedIndexChanged += cmbCedula_SelectedIndexChanged;
            // 
            // frmProfilesAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 100);
            ClientSize = new Size(839, 554);
            Controls.Add(cmbCedula);
            Controls.Add(lblBirthDate);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProfilesAdmin";
            Text = "frmProfilesAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBirthDate;
        private Label lblPhoneNumber;
        private Label lblEmail;
        private Label lblName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label9;
        private ComboBox cmbCedula;
    }
}