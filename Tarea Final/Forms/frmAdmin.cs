﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Tarea_Final.Models;

namespace Tarea_Final
{
    public partial class frmAdmin : Form
    {
        private User user { get; set; }

        public frmAdmin(User user)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.user = user;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int iParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TogglePanelVisibility(Panel panelToShow)
        {
            if (panelToShow != null)
            {
                if (panelToShow.Visible)
                {
                    panelToShow.Visible = false;
                }
                else
                {
                    panelCitas.Visible = panelToShow == panelCitas;
                    panelEmpleado.Visible = panelToShow == panelEmpleado;
                    panelClientes.Visible = panelToShow == panelClientes;
                }
            }
            else
            {
                panelCitas.Visible = false;
                panelEmpleado.Visible = false;
                panelClientes.Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TogglePanelVisibility(panelCitas);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            TogglePanelVisibility(panelClientes);
        }

        private void txtEmpleados_Click(object sender, EventArgs e)
        {
            TogglePanelVisibility(panelEmpleado);
        }

        private void HideLabelsAndLogo()
        {
        }

        private void OpenForm(Form form)
        {
            HideLabelsAndLogo();
            AbrirForm(form);
            TogglePanelVisibility(null!);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            OpenForm(new frmHistory());
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            OpenForm(new frmConsultProfiles());
        }

        private void btnAñadirCitas_Click(object sender, EventArgs e)
        {
            OpenForm(new frmNewUser());
        }

        private void btnConsultarCitas_Click(object sender, EventArgs e)
        {
            OpenForm(new frmConsultUser(user));
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            OpenForm(new frmNewEmployee());
        }

        private void btnConsultarEmpleado_Click(object sender, EventArgs e)
        {
            OpenForm(new frmConsultEmployee());
        }

        private void btnNuevoCitas_Click(object sender, EventArgs e)
        {
            OpenForm(new frmNewAppointment(user));
        }

        private void btnConsultarCitas_Click_1(object sender, EventArgs e)
        {
            OpenForm(new frmConsultAppointment(user));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new frmIniciarSeccion();
            formulario.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void AbrirForm(object frm)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            Form? fh = frm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
    }
}
