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

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                User user = await User.ValidateUser(txtEmail.Text, txtContraseña.Text);

                if (user.IsAdmin)
                {
                    frmAdmin frmAdmin = new frmAdmin();
                    frmAdmin.Show();
                    this.Hide();
                }
                else
                {
                    frmUsuario frmUser = new frmUsuario();
                    frmUser.Show();
                    this.Hide();
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Se produjo un error al validar el usuario: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbMostras_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostras.Checked)
            {
                if (txtContraseña.PasswordChar == '*')
                {
                    txtContraseña.PasswordChar = '\0';
                }
            }
            else
            {
                txtContraseña.PasswordChar = '*';
            }
        }

        private void lbRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.Show();
            this.Hide();
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