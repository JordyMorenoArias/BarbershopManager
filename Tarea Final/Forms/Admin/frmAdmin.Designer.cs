namespace Tarea_Final
{
    partial class frmAdmin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            panel2 = new Panel();
            panelContener = new Panel();
            panel5 = new Panel();
            btnRestaurar = new Button();
            btnMinimizar = new Button();
            btnMaximizar = new Button();
            btnCerrar = new Button();
            btnHistorial = new Button();
            btnCitas = new Button();
            btnCliente = new Button();
            button5 = new Button();
            panel1 = new Panel();
            btnHome = new FontAwesome.Sharp.IconButton();
            panel9 = new Panel();
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panelCitas = new Panel();
            btnConsultarCitas = new Button();
            panel15 = new Panel();
            btnNuevoCitas = new Button();
            panel16 = new Panel();
            panelClientes = new Panel();
            btnConsultar = new Button();
            panel11 = new Panel();
            btnPerfil = new Button();
            panel10 = new Panel();
            panelEmpleado = new Panel();
            btnConsultarEmpleado = new Button();
            panel12 = new Panel();
            btnNuevoEmpleado = new Button();
            panel13 = new Panel();
            btnEmpleados = new Button();
            panel4 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel3 = new Panel();
            lblHoraActual = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panelContenedor = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelCitas.SuspendLayout();
            panelClientes.SuspendLayout();
            panelEmpleado.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 38, 70);
            panel2.Controls.Add(panelContener);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(btnRestaurar);
            panel2.Controls.Add(btnMinimizar);
            panel2.Controls.Add(btnMaximizar);
            panel2.Controls.Add(btnCerrar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1070, 29);
            panel2.TabIndex = 27;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // panelContener
            // 
            panelContener.Location = new Point(231, 29);
            panelContener.Margin = new Padding(3, 2, 3, 2);
            panelContener.Name = "panelContener";
            panelContener.Size = new Size(644, 498);
            panelContener.TabIndex = 40;
            // 
            // panel5
            // 
            panel5.Location = new Point(231, 29);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(219, 94);
            panel5.TabIndex = 38;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.BackgroundImage = (Image)resources.GetObject("btnRestaurar.BackgroundImage");
            btnRestaurar.BackgroundImageLayout = ImageLayout.Zoom;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.FlatAppearance.BorderSize = 0;
            btnRestaurar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRestaurar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRestaurar.FlatStyle = FlatStyle.Flat;
            btnRestaurar.Location = new Point(1027, 4);
            btnRestaurar.Margin = new Padding(3, 2, 3, 2);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(18, 20);
            btnRestaurar.TabIndex = 37;
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackgroundImage = (Image)resources.GetObject("btnMinimizar.BackgroundImage");
            btnMinimizar.BackgroundImageLayout = ImageLayout.Zoom;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Location = new Point(1004, 4);
            btnMinimizar.Margin = new Padding(3, 2, 3, 2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(18, 20);
            btnMinimizar.TabIndex = 35;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.BackgroundImage = (Image)resources.GetObject("btnMaximizar.BackgroundImage");
            btnMaximizar.BackgroundImageLayout = ImageLayout.Zoom;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMaximizar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.Location = new Point(1027, 4);
            btnMaximizar.Margin = new Padding(3, 2, 3, 2);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(18, 20);
            btnMaximizar.TabIndex = 36;
            btnMaximizar.UseVisualStyleBackColor = true;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(1049, 4);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(18, 20);
            btnCerrar.TabIndex = 27;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.FromArgb(26, 32, 40);
            btnHistorial.FlatAppearance.BorderSize = 0;
            btnHistorial.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnHistorial.ForeColor = Color.White;
            btnHistorial.Image = (Image)resources.GetObject("btnHistorial.Image");
            btnHistorial.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistorial.Location = new Point(16, 367);
            btnHistorial.Margin = new Padding(3, 2, 3, 2);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(214, 34);
            btnHistorial.TabIndex = 33;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = false;
            // 
            // btnCitas
            // 
            btnCitas.BackColor = Color.FromArgb(26, 32, 40);
            btnCitas.BackgroundImageLayout = ImageLayout.Zoom;
            btnCitas.FlatAppearance.BorderSize = 0;
            btnCitas.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnCitas.FlatStyle = FlatStyle.Flat;
            btnCitas.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCitas.ForeColor = Color.White;
            btnCitas.Image = (Image)resources.GetObject("btnCitas.Image");
            btnCitas.ImageAlign = ContentAlignment.MiddleLeft;
            btnCitas.Location = new Point(12, 236);
            btnCitas.Margin = new Padding(3, 2, 3, 2);
            btnCitas.Name = "btnCitas";
            btnCitas.RightToLeft = RightToLeft.No;
            btnCitas.Size = new Size(217, 34);
            btnCitas.TabIndex = 28;
            btnCitas.Text = "Citas";
            btnCitas.UseVisualStyleBackColor = false;
            btnCitas.Click += button1_Click_1;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(26, 32, 40);
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCliente.ForeColor = Color.White;
            btnCliente.Image = (Image)resources.GetObject("btnCliente.Image");
            btnCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnCliente.Location = new Point(12, 322);
            btnCliente.Margin = new Padding(3, 2, 3, 2);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(217, 34);
            btnCliente.TabIndex = 31;
            btnCliente.Text = "Clientes";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(26, 32, 40);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(12, 413);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(217, 34);
            button5.TabIndex = 32;
            button5.Text = "Perfiles";
            button5.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 32, 40);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panelCitas);
            panel1.Controls.Add(panelClientes);
            panel1.Controls.Add(panelEmpleado);
            panel1.Controls.Add(btnEmpleados);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(btnHistorial);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(btnCliente);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(btnCitas);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 29);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 554);
            panel1.TabIndex = 34;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(26, 32, 40);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.FromArgb(224, 224, 224);
            btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            btnHome.IconColor = Color.FromArgb(224, 224, 224);
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(13, 197);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(217, 34);
            btnHome.TabIndex = 45;
            btnHome.Text = "Inicio";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(0, 80, 200);
            panel9.Location = new Point(2, 197);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(9, 34);
            panel9.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(101, 533);
            label1.Name = "label1";
            label1.Size = new Size(120, 21);
            label1.TabIndex = 42;
            label1.Text = "Administrador";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(1, 515);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(52, 40);
            button1.TabIndex = 40;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // panelCitas
            // 
            panelCitas.Controls.Add(btnConsultarCitas);
            panelCitas.Controls.Add(panel15);
            panelCitas.Controls.Add(btnNuevoCitas);
            panelCitas.Controls.Add(panel16);
            panelCitas.Location = new Point(61, 272);
            panelCitas.Margin = new Padding(3, 2, 3, 2);
            panelCitas.Name = "panelCitas";
            panelCitas.Size = new Size(168, 69);
            panelCitas.TabIndex = 38;
            panelCitas.Visible = false;
            // 
            // btnConsultarCitas
            // 
            btnConsultarCitas.BackColor = Color.FromArgb(26, 32, 40);
            btnConsultarCitas.FlatAppearance.BorderSize = 0;
            btnConsultarCitas.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnConsultarCitas.FlatStyle = FlatStyle.Flat;
            btnConsultarCitas.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultarCitas.ForeColor = Color.White;
            btnConsultarCitas.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultarCitas.Location = new Point(10, 34);
            btnConsultarCitas.Margin = new Padding(3, 2, 3, 2);
            btnConsultarCitas.Name = "btnConsultarCitas";
            btnConsultarCitas.Size = new Size(127, 25);
            btnConsultarCitas.TabIndex = 37;
            btnConsultarCitas.Text = "Consultar";
            btnConsultarCitas.UseVisualStyleBackColor = false;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(0, 80, 200);
            panel15.Location = new Point(-1, 34);
            panel15.Margin = new Padding(3, 2, 3, 2);
            panel15.Name = "panel15";
            panel15.Size = new Size(9, 25);
            panel15.TabIndex = 38;
            // 
            // btnNuevoCitas
            // 
            btnNuevoCitas.BackColor = Color.FromArgb(26, 32, 40);
            btnNuevoCitas.FlatAppearance.BorderSize = 0;
            btnNuevoCitas.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnNuevoCitas.FlatStyle = FlatStyle.Flat;
            btnNuevoCitas.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoCitas.ForeColor = Color.White;
            btnNuevoCitas.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoCitas.Location = new Point(10, 2);
            btnNuevoCitas.Margin = new Padding(3, 2, 3, 2);
            btnNuevoCitas.Name = "btnNuevoCitas";
            btnNuevoCitas.Size = new Size(127, 25);
            btnNuevoCitas.TabIndex = 35;
            btnNuevoCitas.Text = "Nuevo";
            btnNuevoCitas.UseVisualStyleBackColor = false;
            btnNuevoCitas.Click += btnNuevoCitas_Click;
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(0, 80, 200);
            panel16.Location = new Point(0, 2);
            panel16.Margin = new Padding(3, 2, 3, 2);
            panel16.Name = "panel16";
            panel16.Size = new Size(9, 25);
            panel16.TabIndex = 36;
            // 
            // panelClientes
            // 
            panelClientes.Controls.Add(btnConsultar);
            panelClientes.Controls.Add(panel11);
            panelClientes.Controls.Add(btnPerfil);
            panelClientes.Controls.Add(panel10);
            panelClientes.Location = new Point(62, 360);
            panelClientes.Margin = new Padding(3, 2, 3, 2);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new Size(168, 72);
            panelClientes.TabIndex = 36;
            panelClientes.Visible = false;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.FromArgb(26, 32, 40);
            btnConsultar.FlatAppearance.BorderSize = 0;
            btnConsultar.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultar.ForeColor = Color.White;
            btnConsultar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultar.Location = new Point(9, 31);
            btnConsultar.Margin = new Padding(3, 2, 3, 2);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(127, 25);
            btnConsultar.TabIndex = 39;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(0, 80, 200);
            panel11.Location = new Point(0, 31);
            panel11.Margin = new Padding(3, 2, 3, 2);
            panel11.Name = "panel11";
            panel11.Size = new Size(9, 25);
            panel11.TabIndex = 38;
            // 
            // btnPerfil
            // 
            btnPerfil.BackColor = Color.FromArgb(26, 32, 40);
            btnPerfil.FlatAppearance.BorderSize = 0;
            btnPerfil.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnPerfil.FlatStyle = FlatStyle.Flat;
            btnPerfil.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnPerfil.ForeColor = Color.White;
            btnPerfil.ImageAlign = ContentAlignment.MiddleLeft;
            btnPerfil.Location = new Point(9, 2);
            btnPerfil.Margin = new Padding(3, 2, 3, 2);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(127, 25);
            btnPerfil.TabIndex = 37;
            btnPerfil.Text = "Perfil";
            btnPerfil.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(0, 80, 200);
            panel10.Location = new Point(0, 2);
            panel10.Margin = new Padding(3, 2, 3, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(9, 25);
            panel10.TabIndex = 36;
            // 
            // panelEmpleado
            // 
            panelEmpleado.Controls.Add(btnConsultarEmpleado);
            panelEmpleado.Controls.Add(panel12);
            panelEmpleado.Controls.Add(btnNuevoEmpleado);
            panelEmpleado.Controls.Add(panel13);
            panelEmpleado.Location = new Point(63, 316);
            panelEmpleado.Margin = new Padding(3, 2, 3, 2);
            panelEmpleado.Name = "panelEmpleado";
            panelEmpleado.Size = new Size(166, 69);
            panelEmpleado.TabIndex = 37;
            panelEmpleado.Visible = false;
            // 
            // btnConsultarEmpleado
            // 
            btnConsultarEmpleado.BackColor = Color.FromArgb(26, 32, 40);
            btnConsultarEmpleado.FlatAppearance.BorderSize = 0;
            btnConsultarEmpleado.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnConsultarEmpleado.FlatStyle = FlatStyle.Flat;
            btnConsultarEmpleado.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultarEmpleado.ForeColor = Color.White;
            btnConsultarEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultarEmpleado.Location = new Point(10, 34);
            btnConsultarEmpleado.Margin = new Padding(3, 2, 3, 2);
            btnConsultarEmpleado.Name = "btnConsultarEmpleado";
            btnConsultarEmpleado.Size = new Size(127, 25);
            btnConsultarEmpleado.TabIndex = 37;
            btnConsultarEmpleado.Text = "Consultar";
            btnConsultarEmpleado.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(0, 80, 200);
            panel12.Location = new Point(-1, 34);
            panel12.Margin = new Padding(3, 2, 3, 2);
            panel12.Name = "panel12";
            panel12.Size = new Size(9, 25);
            panel12.TabIndex = 38;
            // 
            // btnNuevoEmpleado
            // 
            btnNuevoEmpleado.BackColor = Color.FromArgb(26, 32, 40);
            btnNuevoEmpleado.FlatAppearance.BorderSize = 0;
            btnNuevoEmpleado.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnNuevoEmpleado.FlatStyle = FlatStyle.Flat;
            btnNuevoEmpleado.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoEmpleado.ForeColor = Color.White;
            btnNuevoEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoEmpleado.Location = new Point(10, 2);
            btnNuevoEmpleado.Margin = new Padding(3, 2, 3, 2);
            btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            btnNuevoEmpleado.Size = new Size(127, 25);
            btnNuevoEmpleado.TabIndex = 35;
            btnNuevoEmpleado.Text = "Nuevo";
            btnNuevoEmpleado.UseVisualStyleBackColor = false;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(0, 80, 200);
            panel13.Location = new Point(0, 2);
            panel13.Margin = new Padding(3, 2, 3, 2);
            panel13.Name = "panel13";
            panel13.Size = new Size(9, 25);
            panel13.TabIndex = 36;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.FromArgb(26, 32, 40);
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmpleados.ForeColor = Color.White;
            btnEmpleados.Image = (Image)resources.GetObject("btnEmpleados.Image");
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(12, 279);
            btnEmpleados.Margin = new Padding(3, 2, 3, 2);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(217, 34);
            btnEmpleados.TabIndex = 36;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += txtEmpleados_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 80, 200);
            panel4.Location = new Point(2, 279);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(9, 34);
            panel4.TabIndex = 37;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 80, 200);
            panel8.Location = new Point(2, 413);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(9, 34);
            panel8.TabIndex = 35;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 80, 200);
            panel7.Location = new Point(2, 367);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(9, 34);
            panel7.TabIndex = 35;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 80, 200);
            panel6.Location = new Point(2, 322);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(9, 34);
            panel6.TabIndex = 35;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 80, 200);
            panel3.Location = new Point(2, 236);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(9, 34);
            panel3.TabIndex = 34;
            // 
            // lblHoraActual
            // 
            lblHoraActual.AutoSize = true;
            lblHoraActual.Location = new Point(238, 171);
            lblHoraActual.Name = "lblHoraActual";
            lblHoraActual.Size = new Size(0, 15);
            lblHoraActual.TabIndex = 35;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Right;
            panelContenedor.Location = new Point(231, 29);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(839, 554);
            panelContenedor.TabIndex = 36;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 100);
            ClientSize = new Size(1070, 583);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            Controls.Add(lblHoraActual);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAdmin";
            Text = "Admin";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelCitas.ResumeLayout(false);
            panelClientes.ResumeLayout(false);
            panelEmpleado.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button btnCerrar;
        private Button btnHistorial;
        private Button btnCitas;
        private Button btnCliente;
        private Button button5;
        private Panel panel1;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel3;
        private Button btnMinimizar;
        private Button btnMaximizar;
        private Button btnRestaurar;
        private Panel panelClientes;
        private Button btnPerfil;
        private Panel panel10;
        private Button btnEmpleados;
        private Panel panel4;
        private Panel panelEmpleado;
        private Button btnConsultarEmpleado;
        private Panel panel12;
        private Button btnNuevoEmpleado;
        private Panel panel13;
        private Panel panelCitas;
        private Button btnConsultarCitas;
        private Panel panel15;
        private Button btnNuevoCitas;
        private Panel panel16;
        private PictureBox pictureBox1;
        private Button button1;
        private Label lblHoraActual;
        private Panel panel5;
        private Panel panelContener;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnHome;
        private Panel panel9;
        private Button btnConsultar;
        private Panel panel11;
        private Panel panelContenedor;
    }
}