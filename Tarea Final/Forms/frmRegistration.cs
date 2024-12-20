using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Tarea_Final.Models;
using System.Text.RegularExpressions;

namespace Tarea_Final
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Form formulario = new frmIniciarSeccion();
            formulario.Show();
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

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            StringBuilder errorMessage = new StringBuilder();

            Match emailMatch = Regex.Match(txtEmail.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            if (!emailMatch.Success)
            {
                isValid = false;
                errorMessage.AppendLine("El correo electrónico no es válido.");
            }

            Match passwordMatch = Regex.Match(txtPassword.Text, @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
            if (!passwordMatch.Success)
            {
                isValid = false;
                errorMessage.AppendLine("La contraseña no es válida. Debe tener al menos 8 caracteres, una letra mayúscula, una letra minúscula, un número y un carácter especial.");
            }

            if (isValid)
            {
                try
                {
                    User user = new User(txtName.Text, txtEmail.Text, txtIdCard.Text, txtPassword.Text, dtpFechaNacimiento.Value, txtTelefono.Text);
                    // Aquí puedes llamar al método CreateUser para guardar el usuario en la base de datos
                    await User.CreateUser(user);

                    DialogResult result = MessageBox.Show("Usuario registrado correctamente.", "Registro Exitoso", MessageBoxButtons.OK);

                    if (result == DialogResult.OK)
                    {
                        Form formulario = new frmIniciarSeccion();
                        formulario.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Se produjo un error al registrar el usuario: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show(errorMessage.ToString());
            }
        }
    }
}
