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

namespace Tarea_Final
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
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
            lblHora.Visible = false;
            lblFecha.Visible = false;
            pbLogo.Visible = false;
            lblLogo.Visible = false;
        }

        private void OpenForm(Form form)
        {
            HideLabelsAndLogo();
            AbrirForm(form);
            TogglePanelVisibility(null!);
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            OpenForm(new frmHistorial());
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
            if (this.panelContene.Controls.Count > 0)
                this.panelContene.Controls.RemoveAt(0);

            Form fh = frm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContene.Controls.Add(fh);
            this.panelContene.Tag = fh;
            fh.Show();
        }

        private void btnNuevoCitas_Click(object sender, EventArgs e)
        {
            OpenForm(new frmNuevaCita());
        }

        private void btnConsultarCitas_Click(object sender, EventArgs e)
        {
            OpenForm(new frmConsulatarCita());
        }

        private void btnAñadirClientes_Click(object sender, EventArgs e)
        {
            OpenForm(new frmNuevoCliente());
        }

        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            OpenForm(new frmConsultarCliente());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH; mm; ss");
            lblFecha.Text = DateTime.Now.ToString("dddd; MMMM; yyyy");
        }
    }
}
