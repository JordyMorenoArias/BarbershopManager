namespace Tarea_Final.Forms
{
    partial class frmStartUser
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
            lblCitasHoy = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listBoxProximasCitas = new ListBox();
            SuspendLayout();
            // 
            // lblCitasHoy
            // 
            lblCitasHoy.AutoSize = true;
            lblCitasHoy.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCitasHoy.ForeColor = Color.Silver;
            lblCitasHoy.Location = new Point(552, 179);
            lblCitasHoy.Name = "lblCitasHoy";
            lblCitasHoy.Size = new Size(22, 24);
            lblCitasHoy.TabIndex = 11;
            lblCitasHoy.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(437, 138);
            label4.Name = "label4";
            label4.Size = new Size(148, 30);
            label4.TabIndex = 10;
            label4.Text = "Estadisticas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(437, 179);
            label3.Name = "label3";
            label3.Size = new Size(109, 24);
            label3.TabIndex = 9;
            label3.Text = "Citas Hoy:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(47, 138);
            label2.Name = "label2";
            label2.Size = new Size(185, 30);
            label2.TabIndex = 8;
            label2.Text = "Próximas Citas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(47, 41);
            label1.Name = "label1";
            label1.Size = new Size(383, 32);
            label1.TabIndex = 7;
            label1.Text = "Baberia Pro - Panel Principal";
            // 
            // listBoxProximasCitas
            // 
            listBoxProximasCitas.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxProximasCitas.FormattingEnabled = true;
            listBoxProximasCitas.ItemHeight = 21;
            listBoxProximasCitas.Location = new Point(47, 179);
            listBoxProximasCitas.Name = "listBoxProximasCitas";
            listBoxProximasCitas.Size = new Size(364, 277);
            listBoxProximasCitas.TabIndex = 6;
            // 
            // frmStartUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 100);
            ClientSize = new Size(654, 498);
            Controls.Add(lblCitasHoy);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxProximasCitas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmStartUser";
            Text = "frmStartUser";
            Load += frmStartUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCitasHoy;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox listBoxProximasCitas;
    }
}