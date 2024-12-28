using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_Final.Forms;
using Tarea_Final.Models;

namespace Tarea_Final
{
    public partial class frmUser : Form
    {
        private User user { get; set; }
        public frmUser(User user)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            this.user = user;
            OpenForm(new frmStartUser(user));
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
            if (this.panelContener.Controls.Count > 0)
                this.panelContener.Controls.RemoveAt(0);

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelContener.Controls.Add(form);
            this.panelContener.Tag = form;
            form.Show();
            TogglePanelVisibility(null!);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
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
                    panelClientes.Visible = panelToShow == panelClientes;
                }
            }
            else
            {
                panelCitas.Visible = false;
                panelClientes.Visible = false;
            }
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            TogglePanelVisibility(panelCitas);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            TogglePanelVisibility(panelClientes);
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            OpenForm(new frmHistoryUser(user));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario = new frmIniciarSeccion();
            formulario.Show();
            this.Close();
        }

        private void btnNuevoCitas_Click(object sender, EventArgs e)
        {
            OpenForm(new frmNewAppointmentUser(user));
        }

        private void btnConsultarCitas_Click(object sender, EventArgs e)
        {
            OpenForm(new frmConsultAppointment(user));
        }

        private void btnAñadirClientes_Click_1(object sender, EventArgs e)
        {
            OpenForm(new frmProfileUser(user));
        }

        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            OpenForm(new frmConsultProfile(user));
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenForm(new frmStartUser(user));
        }
    }
}
