using System;
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
using Tarea_Final.Forms;
using Tarea_Final.Forms.Admin;

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
            OpenForm(new frmStartAdmin());
            btnHome.FlatAppearance.BorderSize = 0;
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

        private void OpenForm(Form form)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(form);
            this.panelContenedor.Tag = form;
            form.Show();
            TogglePanelVisibility(null!);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new frmIniciarSeccion();
            formulario.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenForm(new frmStartAdmin());
        }

        private void btnNuevoCitas_Click(object sender, EventArgs e)
        {
            OpenForm(new frmNewAppointmentAdmin(user));
        }

        private void btnConsultarCitas_Click(object sender, EventArgs e)
        {
            OpenForm(new frmConsultAppointmentAdmin(user));
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            OpenForm(new frmNewEmployeeAdmin(user));
        }

        private void btnConsultarEmpleado_Click(object sender, EventArgs e)
        {
            OpenForm(new frmConsultEmployeeAdmin());
        }
    }
}
