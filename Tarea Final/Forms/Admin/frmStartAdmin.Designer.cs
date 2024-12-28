namespace Tarea_Final.Forms
{
    partial class frmStartAdmin
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
            label2 = new Label();
            label1 = new Label();
            listBoxProximasCitas = new ListBox();
            label4 = new Label();
            lblCitaSem = new Label();
            label3 = new Label();
            lblGanProx = new Label();
            lblGanProxSem = new Label();
            label7 = new Label();
            lblGanEsteMes = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(36, 153);
            label2.Name = "label2";
            label2.Size = new Size(185, 30);
            label2.TabIndex = 13;
            label2.Text = "Próximas Citas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(36, 55);
            label1.Name = "label1";
            label1.Size = new Size(383, 32);
            label1.TabIndex = 12;
            label1.Text = "Baberia Pro - Panel Principal";
            // 
            // listBoxProximasCitas
            // 
            listBoxProximasCitas.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxProximasCitas.FormattingEnabled = true;
            listBoxProximasCitas.ItemHeight = 21;
            listBoxProximasCitas.Location = new Point(36, 204);
            listBoxProximasCitas.Name = "listBoxProximasCitas";
            listBoxProximasCitas.Size = new Size(490, 298);
            listBoxProximasCitas.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(545, 153);
            label4.Name = "label4";
            label4.Size = new Size(148, 30);
            label4.TabIndex = 15;
            label4.Text = "Estadisticas";
            // 
            // lblCitaSem
            // 
            lblCitaSem.AutoSize = true;
            lblCitaSem.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCitaSem.ForeColor = Color.Silver;
            lblCitaSem.Location = new Point(702, 204);
            lblCitaSem.Name = "lblCitaSem";
            lblCitaSem.Size = new Size(21, 22);
            lblCitaSem.TabIndex = 17;
            lblCitaSem.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(545, 205);
            label3.Name = "label3";
            label3.Size = new Size(151, 21);
            label3.TabIndex = 16;
            label3.Text = "Citas para la Sem:";
            // 
            // lblGanProx
            // 
            lblGanProx.AutoSize = true;
            lblGanProx.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGanProx.ForeColor = Color.Silver;
            lblGanProx.Location = new Point(545, 249);
            lblGanProx.Name = "lblGanProx";
            lblGanProx.Size = new Size(194, 21);
            lblGanProx.TabIndex = 18;
            lblGanProx.Text = "Ganancias Est. Próx. 7d:";
            // 
            // lblGanProxSem
            // 
            lblGanProxSem.AutoSize = true;
            lblGanProxSem.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblGanProxSem.ForeColor = Color.Silver;
            lblGanProxSem.Location = new Point(745, 249);
            lblGanProxSem.Name = "lblGanProxSem";
            lblGanProxSem.Size = new Size(21, 22);
            lblGanProxSem.TabIndex = 19;
            lblGanProxSem.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(548, 291);
            label7.Name = "label7";
            label7.Size = new Size(197, 21);
            label7.TabIndex = 20;
            label7.Text = "Ganancias De Este Mes:";
            // 
            // lblGanEsteMes
            // 
            lblGanEsteMes.AutoSize = true;
            lblGanEsteMes.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblGanEsteMes.ForeColor = Color.Silver;
            lblGanEsteMes.Location = new Point(751, 290);
            lblGanEsteMes.Name = "lblGanEsteMes";
            lblGanEsteMes.Size = new Size(21, 22);
            lblGanEsteMes.TabIndex = 21;
            lblGanEsteMes.Text = "0";
            lblGanEsteMes.Click += label8_Click;
            // 
            // frmStartAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 100);
            ClientSize = new Size(839, 554);
            Controls.Add(lblGanEsteMes);
            Controls.Add(label7);
            Controls.Add(lblGanProxSem);
            Controls.Add(lblGanProx);
            Controls.Add(lblCitaSem);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxProximasCitas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmStartAdmin";
            Text = "frmStartAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private ListBox listBoxProximasCitas;
        private Label label4;
        private Label lblCitaSem;
        private Label label3;
        private Label lblGanProx;
        private Label lblGanProxSem;
        private Label label7;
        private Label lblGanEsteMes;
    }
}