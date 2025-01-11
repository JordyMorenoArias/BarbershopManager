namespace Tarea_Final.Forms.Admin
{
    partial class frmConsultUsers
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
            cmbEmail = new ComboBox();
            label7 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label9 = new Label();
            txtName = new TextBox();
            txtIdCard = new TextBox();
            txtPhoneNumber = new TextBox();
            label1 = new Label();
            txtIsAdmin = new ComboBox();
            btnCrear = new Button();
            dvgHistory = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnAction = new DataGridViewTextBoxColumn();
            ColumnDate = new DataGridViewTextBoxColumn();
            ColumnDetails = new DataGridViewTextBoxColumn();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgHistory).BeginInit();
            SuspendLayout();
            // 
            // cmbEmail
            // 
            cmbEmail.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEmail.FormattingEnabled = true;
            cmbEmail.Location = new Point(154, 142);
            cmbEmail.Margin = new Padding(3, 2, 3, 2);
            cmbEmail.Name = "cmbEmail";
            cmbEmail.Size = new Size(276, 27);
            cmbEmail.TabIndex = 116;
            cmbEmail.SelectedIndexChanged += cmbEmail_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(33, 298);
            label7.Name = "label7";
            label7.Size = new Size(92, 24);
            label7.TabIndex = 115;
            label7.Text = "Cedula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(33, 145);
            label2.Name = "label2";
            label2.Size = new Size(69, 24);
            label2.TabIndex = 105;
            label2.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(33, 218);
            label4.Name = "label4";
            label4.Size = new Size(100, 24);
            label4.TabIndex = 104;
            label4.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(33, 374);
            label5.Name = "label5";
            label5.Size = new Size(104, 24);
            label5.TabIndex = 107;
            label5.Text = "Telefono:";
            label5.Click += label5_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Silver;
            label9.Location = new Point(33, 50);
            label9.Name = "label9";
            label9.Size = new Size(239, 33);
            label9.TabIndex = 117;
            label9.Text = "Consultar Usuario";
            // 
            // txtName
            // 
            txtName.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(154, 216);
            txtName.Name = "txtName";
            txtName.Size = new Size(276, 26);
            txtName.TabIndex = 119;
            // 
            // txtIdCard
            // 
            txtIdCard.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdCard.Location = new Point(154, 298);
            txtIdCard.Name = "txtIdCard";
            txtIdCard.Size = new Size(276, 26);
            txtIdCard.TabIndex = 120;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhoneNumber.Location = new Point(154, 374);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(276, 26);
            txtPhoneNumber.TabIndex = 121;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(33, 449);
            label1.Name = "label1";
            label1.Size = new Size(106, 24);
            label1.TabIndex = 122;
            label1.Text = "Es Admin:";
            // 
            // txtIsAdmin
            // 
            txtIsAdmin.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtIsAdmin.FormattingEnabled = true;
            txtIsAdmin.Items.AddRange(new object[] { "No lo Es", "Si lo Es" });
            txtIsAdmin.Location = new Point(154, 446);
            txtIsAdmin.Margin = new Padding(3, 2, 3, 2);
            txtIsAdmin.Name = "txtIsAdmin";
            txtIsAdmin.Size = new Size(276, 27);
            txtIsAdmin.TabIndex = 123;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(26, 32, 40);
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrear.ForeColor = Color.White;
            btnCrear.ImageAlign = ContentAlignment.MiddleLeft;
            btnCrear.Location = new Point(705, 490);
            btnCrear.Margin = new Padding(3, 2, 3, 2);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(103, 33);
            btnCrear.TabIndex = 124;
            btnCrear.Text = "Aplicar";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // dvgHistory
            // 
            dvgHistory.AllowUserToAddRows = false;
            dvgHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgHistory.BackgroundColor = Color.FromArgb(30, 38, 70);
            dvgHistory.BorderStyle = BorderStyle.None;
            dvgHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgHistory.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnAction, ColumnDate, ColumnDetails });
            dvgHistory.Location = new Point(447, 142);
            dvgHistory.Name = "dvgHistory";
            dvgHistory.ReadOnly = true;
            dvgHistory.RowHeadersVisible = false;
            dvgHistory.RowTemplate.Height = 25;
            dvgHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgHistory.Size = new Size(361, 331);
            dvgHistory.TabIndex = 125;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Id History";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            ColumnId.Visible = false;
            // 
            // ColumnAction
            // 
            ColumnAction.HeaderText = "Action";
            ColumnAction.Name = "ColumnAction";
            ColumnAction.ReadOnly = true;
            // 
            // ColumnDate
            // 
            ColumnDate.HeaderText = "Date";
            ColumnDate.Name = "ColumnDate";
            ColumnDate.ReadOnly = true;
            // 
            // ColumnDetails
            // 
            ColumnDetails.HeaderText = "Details";
            ColumnDetails.Name = "ColumnDetails";
            ColumnDetails.ReadOnly = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(447, 115);
            label3.Name = "label3";
            label3.Size = new Size(107, 24);
            label3.TabIndex = 126;
            label3.Text = "Actividad";
            // 
            // frmConsultUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 100);
            ClientSize = new Size(839, 554);
            Controls.Add(label3);
            Controls.Add(dvgHistory);
            Controls.Add(btnCrear);
            Controls.Add(txtIsAdmin);
            Controls.Add(label1);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtIdCard);
            Controls.Add(txtName);
            Controls.Add(label9);
            Controls.Add(cmbEmail);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmConsultUsers";
            Text = "frmConsultUsers";
            ((System.ComponentModel.ISupportInitialize)dvgHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbEmail;
        private Label label7;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label9;
        private TextBox txtName;
        private TextBox txtIdCard;
        private TextBox txtPhoneNumber;
        private Label label1;
        private ComboBox txtIsAdmin;
        private Button btnCrear;
        private DataGridView dvgHistory;
        private Label label3;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnAction;
        private DataGridViewTextBoxColumn ColumnDate;
        private DataGridViewTextBoxColumn ColumnDetails;
    }
}