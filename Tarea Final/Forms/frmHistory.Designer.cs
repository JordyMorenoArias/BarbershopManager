namespace Tarea_Final
{
    partial class frmHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistory));
            dgvHistory = new DataGridView();
            ColumnIdHistory = new DataGridViewTextBoxColumn();
            ColumnUserId = new DataGridViewTextBoxColumn();
            ColumnTableName = new DataGridViewTextBoxColumn();
            ColumnAction = new DataGridViewTextBoxColumn();
            ColumnActionDate = new DataGridViewTextBoxColumn();
            ColumnDetails = new DataGridViewTextBoxColumn();
            label9 = new Label();
            btnBuscar = new Button();
            txtcedula = new TextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.BackgroundColor = Color.FromArgb(30, 38, 70);
            dgvHistory.BorderStyle = BorderStyle.None;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Columns.AddRange(new DataGridViewColumn[] { ColumnIdHistory, ColumnUserId, ColumnTableName, ColumnAction, ColumnActionDate, ColumnDetails });
            dgvHistory.Location = new Point(18, 134);
            dgvHistory.Margin = new Padding(3, 2, 3, 2);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.RowTemplate.Height = 29;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(616, 319);
            dgvHistory.TabIndex = 0;
            // 
            // ColumnIdHistory
            // 
            ColumnIdHistory.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColumnIdHistory.Frozen = true;
            ColumnIdHistory.HeaderText = "IdHistory";
            ColumnIdHistory.Name = "ColumnIdHistory";
            ColumnIdHistory.ReadOnly = true;
            ColumnIdHistory.Visible = false;
            ColumnIdHistory.Width = 154;
            // 
            // ColumnUserId
            // 
            ColumnUserId.HeaderText = "UserId";
            ColumnUserId.Name = "ColumnUserId";
            ColumnUserId.ReadOnly = true;
            ColumnUserId.Resizable = DataGridViewTriState.False;
            ColumnUserId.Visible = false;
            // 
            // ColumnTableName
            // 
            ColumnTableName.HeaderText = "TableName";
            ColumnTableName.Name = "ColumnTableName";
            ColumnTableName.ReadOnly = true;
            ColumnTableName.Visible = false;
            // 
            // ColumnAction
            // 
            ColumnAction.HeaderText = "Action";
            ColumnAction.Name = "ColumnAction";
            ColumnAction.ReadOnly = true;
            // 
            // ColumnActionDate
            // 
            ColumnActionDate.HeaderText = "Date";
            ColumnActionDate.Name = "ColumnActionDate";
            ColumnActionDate.ReadOnly = true;
            // 
            // ColumnDetails
            // 
            ColumnDetails.HeaderText = "Details";
            ColumnDetails.Name = "ColumnDetails";
            ColumnDetails.ReadOnly = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 25.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Silver;
            label9.Location = new Point(18, 25);
            label9.Name = "label9";
            label9.Size = new Size(146, 42);
            label9.TabIndex = 61;
            label9.Text = "Historial";
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
            btnBuscar.Location = new Point(524, 104);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 25);
            btnBuscar.TabIndex = 64;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtcedula
            // 
            txtcedula.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtcedula.Location = new Point(18, 105);
            txtcedula.Margin = new Padding(3, 2, 3, 2);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(486, 24);
            txtcedula.TabIndex = 63;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Silver;
            label10.Location = new Point(18, 87);
            label10.Name = "label10";
            label10.Size = new Size(61, 19);
            label10.TabIndex = 62;
            label10.Text = "Cedula";
            // 
            // frmHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 100);
            ClientSize = new Size(654, 498);
            Controls.Add(btnBuscar);
            Controls.Add(txtcedula);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dgvHistory);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmHistory";
            Text = "Historial";
            Load += Historial_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHistory;
        private Label label9;
        private Button btnBuscar;
        private TextBox txtcedula;
        private Label label10;
        private DataGridViewTextBoxColumn ColumnIdHistory;
        private DataGridViewTextBoxColumn ColumnUserId;
        private DataGridViewTextBoxColumn ColumnTableName;
        private DataGridViewTextBoxColumn ColumnAction;
        private DataGridViewTextBoxColumn ColumnActionDate;
        private DataGridViewTextBoxColumn ColumnDetails;
    }
}