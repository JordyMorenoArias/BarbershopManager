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

        private void HideLabelsAndLogo()
        {
        }

        private void OpenForm(Form form)
        {
            HideLabelsAndLogo();
            AbrirForm(form);
            TogglePanelVisibility(null!);
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            OpenForm(new frmHistory());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario = new frmIniciarSeccion();
            formulario.Show();
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int iParam);

        private void panel2_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirForm(object frm)
        {
            if (this.panelContener.Controls.Count > 0)
                this.panelContener.Controls.RemoveAt(0);

            Form fh = frm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContener.Controls.Add(fh);
            this.panelContener.Tag = fh;
            fh.Show();
        }

        private void btnNuevoCitas_Click(object sender, EventArgs e)
        {
            OpenForm(new frmNewAppointment(user));
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
            OpenForm(new frmConsultUser(user));
        }
    }
}
