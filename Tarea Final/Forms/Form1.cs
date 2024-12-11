using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Tarea_Final.Models;

namespace Tarea_Final
{
    public partial class frmIniciarSeccion : Form
    {
        public frmIniciarSeccion()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void logear(string Usuario, string Contraseña)
        {
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            frmAdmin frmAdmin = new frmAdmin();
            frmAdmin.Show();
            //logear(this.txtUsuario.Text, this.txtContraseña.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbMostras_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void lbRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int iParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}