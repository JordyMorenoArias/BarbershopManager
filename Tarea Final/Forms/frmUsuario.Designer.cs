namespace Tarea_Final
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            panel1 = new Panel();
            label1 = new Label();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            panelCitas = new Panel();
            btnConsultarCitas = new Button();
            panel15 = new Panel();
            btnNuevoCitas = new Button();
            panel16 = new Panel();
            btnPerfil = new Button();
            panelClientes = new Panel();
            btnConsultarClientes = new Button();
            panel11 = new Panel();
            btnAñadirClientes = new Button();
            panel10 = new Panel();
            panel8 = new Panel();
            btnHistorial = new Button();
            panel7 = new Panel();
            btnCliente = new Button();
            panel6 = new Panel();
            btnCitas = new Button();
            panel3 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panelContener = new Panel();
            btnCerrar = new Button();
            btnMaximizar = new Button();
            btnMinimizar = new Button();
            btnRestaurar = new Button();
            panel5 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelContenedor = new Panel();
            panel14 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelCitas.SuspendLayout();
            panelClientes.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 32, 40);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panelCitas);
            panel1.Controls.Add(btnPerfil);
            panel1.Controls.Add(panelClientes);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(btnHistorial);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(btnCliente);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(btnCitas);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 29);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 498);
            panel1.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(154, 473);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 41;
            label1.Text = "Usuario";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(26, 32, 40);
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Cursor = Cursors.Hand;
            button5.Location = new Point(0, 456);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(52, 40);
            button5.TabIndex = 40;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
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
            panelCitas.Location = new Point(53, 230);
            panelCitas.Margin = new Padding(3, 2, 3, 2);
            panelCitas.Name = "panelCitas";
            panelCitas.Size = new Size(174, 69);
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
            btnConsultarCitas.Click += btnConsultarCitas_Click;
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
            // btnPerfil
            // 
            btnPerfil.BackColor = Color.FromArgb(26, 32, 40);
            btnPerfil.FlatAppearance.BorderSize = 0;
            btnPerfil.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnPerfil.FlatStyle = FlatStyle.Flat;
            btnPerfil.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnPerfil.ForeColor = Color.White;
            btnPerfil.Image = (Image)resources.GetObject("btnPerfil.Image");
            btnPerfil.ImageAlign = ContentAlignment.MiddleLeft;
            btnPerfil.Location = new Point(10, 337);
            btnPerfil.Margin = new Padding(3, 2, 3, 2);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(217, 34);
            btnPerfil.TabIndex = 32;
            btnPerfil.Text = "Perfil";
            btnPerfil.UseVisualStyleBackColor = false;
            // 
            // panelClientes
            // 
            panelClientes.Controls.Add(btnConsultarClientes);
            panelClientes.Controls.Add(panel11);
            panelClientes.Controls.Add(btnAñadirClientes);
            panelClientes.Controls.Add(panel10);
            panelClientes.Location = new Point(52, 284);
            panelClientes.Margin = new Padding(3, 2, 3, 2);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new Size(175, 69);
            panelClientes.TabIndex = 36;
            panelClientes.Visible = false;
            // 
            // btnConsultarClientes
            // 
            btnConsultarClientes.BackColor = Color.FromArgb(26, 32, 40);
            btnConsultarClientes.FlatAppearance.BorderSize = 0;
            btnConsultarClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnConsultarClientes.FlatStyle = FlatStyle.Flat;
            btnConsultarClientes.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultarClientes.ForeColor = Color.White;
            btnConsultarClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultarClientes.Location = new Point(10, 34);
            btnConsultarClientes.Margin = new Padding(3, 2, 3, 2);
            btnConsultarClientes.Name = "btnConsultarClientes";
            btnConsultarClientes.Size = new Size(127, 25);
            btnConsultarClientes.TabIndex = 37;
            btnConsultarClientes.Text = "Consultar";
            btnConsultarClientes.UseVisualStyleBackColor = false;
            btnConsultarClientes.Click += btnConsultarClientes_Click;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(0, 80, 200);
            panel11.Location = new Point(-1, 34);
            panel11.Margin = new Padding(3, 2, 3, 2);
            panel11.Name = "panel11";
            panel11.Size = new Size(9, 25);
            panel11.TabIndex = 38;
            // 
            // btnAñadirClientes
            // 
            btnAñadirClientes.BackColor = Color.FromArgb(26, 32, 40);
            btnAñadirClientes.FlatAppearance.BorderSize = 0;
            btnAñadirClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 70);
            btnAñadirClientes.FlatStyle = FlatStyle.Flat;
            btnAñadirClientes.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAñadirClientes.ForeColor = Color.White;
            btnAñadirClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnAñadirClientes.Location = new Point(10, 2);
            btnAñadirClientes.Margin = new Padding(3, 2, 3, 2);
            btnAñadirClientes.Name = "btnAñadirClientes";
            btnAñadirClientes.Size = new Size(127, 25);
            btnAñadirClientes.TabIndex = 35;
            btnAñadirClientes.Text = "Añadir";
            btnAñadirClientes.UseVisualStyleBackColor = false;
            btnAñadirClientes.Click += btnAñadirClientes_Click;
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
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 80, 200);
            panel8.Location = new Point(0, 337);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(9, 34);
            panel8.TabIndex = 35;
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
            btnHistorial.Location = new Point(14, 290);
            btnHistorial.Margin = new Padding(3, 2, 3, 2);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(214, 34);
            btnHistorial.TabIndex = 33;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 80, 200);
            panel7.Location = new Point(0, 290);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(9, 34);
            panel7.TabIndex = 35;
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
            btnCliente.Location = new Point(10, 245);
            btnCliente.Margin = new Padding(3, 2, 3, 2);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(217, 34);
            btnCliente.TabIndex = 31;
            btnCliente.Text = "Clientes";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 80, 200);
            panel6.Location = new Point(0, 245);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(9, 34);
            panel6.TabIndex = 35;
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
            btnCitas.Location = new Point(10, 200);
            btnCitas.Margin = new Padding(3, 2, 3, 2);
            btnCitas.Name = "btnCitas";
            btnCitas.RightToLeft = RightToLeft.No;
            btnCitas.Size = new Size(217, 34);
            btnCitas.TabIndex = 28;
            btnCitas.Text = "Citas";
            btnCitas.UseVisualStyleBackColor = false;
            btnCitas.Click += btnCitas_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 80, 200);
            panel3.Location = new Point(0, 200);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(9, 34);
            panel3.TabIndex = 34;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panelContener
            // 
            panelContener.Dock = DockStyle.Right;
            panelContener.Location = new Point(231, 29);
            panelContener.Margin = new Padding(3, 2, 3, 2);
            panelContener.Name = "panelContener";
            panelContener.Size = new Size(654, 498);
            panelContener.TabIndex = 44;
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
            btnCerrar.Location = new Point(1568, 4);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(18, 20);
            btnCerrar.TabIndex = 27;
            btnCerrar.UseVisualStyleBackColor = true;
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
            btnMaximizar.Location = new Point(1546, 4);
            btnMaximizar.Margin = new Padding(3, 2, 3, 2);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(18, 20);
            btnMaximizar.TabIndex = 36;
            btnMaximizar.UseVisualStyleBackColor = true;
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
            btnMinimizar.Location = new Point(1523, 4);
            btnMinimizar.Margin = new Padding(3, 2, 3, 2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(18, 20);
            btnMinimizar.TabIndex = 35;
            btnMinimizar.UseVisualStyleBackColor = true;
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
            btnRestaurar.Location = new Point(1546, 4);
            btnRestaurar.Margin = new Padding(3, 2, 3, 2);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(18, 20);
            btnRestaurar.TabIndex = 37;
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Visible = false;
            // 
            // panel5
            // 
            panel5.Location = new Point(231, 29);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(219, 94);
            panel5.TabIndex = 38;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(864, 2);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(18, 20);
            button4.TabIndex = 39;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(841, 2);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(18, 20);
            button3.TabIndex = 41;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(818, 2);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(18, 20);
            button2.TabIndex = 40;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(841, 2);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(18, 20);
            button1.TabIndex = 42;
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Location = new Point(231, 29);
            panelContenedor.Margin = new Padding(3, 2, 3, 2);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(641, 480);
            panelContenedor.TabIndex = 44;
            // 
            // panel14
            // 
            panel14.Location = new Point(228, 29);
            panel14.Margin = new Padding(3, 2, 3, 2);
            panel14.Name = "panel14";
            panel14.Size = new Size(641, 494);
            panel14.TabIndex = 44;
            // 
            // panel4
            // 
            panel4.Location = new Point(230, 29);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(653, 494);
            panel4.TabIndex = 44;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 38, 70);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel14);
            panel2.Controls.Add(panelContenedor);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(btnRestaurar);
            panel2.Controls.Add(btnMinimizar);
            panel2.Controls.Add(btnMaximizar);
            panel2.Controls.Add(btnCerrar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(885, 29);
            panel2.TabIndex = 28;
            panel2.MouseDown += panel2_MouseDown_1;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 100);
            ClientSize = new Size(885, 527);
            Controls.Add(panelContener);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmUsuario";
            Text = "Usuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelCitas.ResumeLayout(false);
            panelClientes.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button5;
        private PictureBox pictureBox1;
        private Panel panelCitas;
        private Button btnConsultarCitas;
        private Panel panel15;
        private Button btnNuevoCitas;
        private Panel panel16;
        private Button btnHistorial;
        private Panel panel7;
        private Button btnCitas;
        private Panel panel3;
        private Panel panelClientes;
        private Button btnConsultarClientes;
        private Panel panel11;
        private Button btnAñadirClientes;
        private Panel panel10;
        private Button btnCliente;
        private Panel panel6;
        private System.Windows.Forms.Timer timer1;
        private Panel panelContener;
        private Label label1;
        private Button btnCerrar;
        private Button btnMaximizar;
        private Button btnMinimizar;
        private Button btnRestaurar;
        private Panel panel5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panelContenedor;
        private Panel panel14;
        private Panel panel4;
        private Panel panel2;
        private Button btnPerfil;
        private Panel panel8;
    }
}