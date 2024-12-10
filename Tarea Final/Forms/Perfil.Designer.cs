namespace Tarea_Final
{
    partial class Perfil
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
            label5 = new Label();
            txtID = new TextBox();
            label9 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtContraseña = new TextBox();
            label1 = new Label();
            txtUsuario = new TextBox();
            btnModificar = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(71, 108);
            label5.Name = "label5";
            label5.Size = new Size(22, 19);
            label5.TabIndex = 75;
            label5.Text = "ID";
            // 
            // txtID
            // 
            txtID.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(71, 126);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(260, 24);
            txtID.TabIndex = 74;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Silver;
            label9.Location = new Point(65, 49);
            label9.Name = "label9";
            label9.Size = new Size(246, 34);
            label9.TabIndex = 73;
            label9.Text = "Consultar Perfiles";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(71, 164);
            label3.Name = "label3";
            label3.Size = new Size(68, 19);
            label3.TabIndex = 70;
            label3.Text = "Nombre ";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(71, 184);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(260, 24);
            txtNombre.TabIndex = 69;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(71, 286);
            label2.Name = "label2";
            label2.Size = new Size(90, 19);
            label2.TabIndex = 68;
            label2.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(71, 304);
            txtContraseña.Margin = new Padding(3, 2, 3, 2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(260, 24);
            txtContraseña.TabIndex = 67;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(71, 224);
            label1.Name = "label1";
            label1.Size = new Size(140, 19);
            label1.TabIndex = 66;
            label1.Text = "Nombre de Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(71, 244);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(260, 24);
            txtUsuario.TabIndex = 65;
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
            btnModificar.Location = new Point(71, 352);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(122, 28);
            btnModificar.TabIndex = 76;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(26, 32, 40);
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.Location = new Point(204, 352);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(127, 28);
            btnCerrar.TabIndex = 77;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // Perfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 100);
            ClientSize = new Size(456, 453);
            Controls.Add(btnCerrar);
            Controls.Add(btnModificar);
            Controls.Add(label5);
            Controls.Add(txtID);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtContraseña);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Perfil";
            Text = "Perfil";
            Load += Perfil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox txtID;
        private Label label9;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtContraseña;
        private Label label1;
        private TextBox txtUsuario;
        private Button btnModificar;
        private Button btnCerrar;
    }
}