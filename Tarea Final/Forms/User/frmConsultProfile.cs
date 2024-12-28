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
using Tarea_Final.Models;

namespace Tarea_Final
{
    public partial class frmConsultProfile : Form
    {
        private Models.User user { get; set; }
        public frmConsultProfile(Models.User user)
        {
            InitializeComponent();
            this.user = user;

            txtIdCard.Text = user.IdCard;
            txtName.Text = user.Name;
            txtEmail.Text = user.Email;
            txtPhoneNumber.Text = user.PhoneNumber;
            dtpFechaNacimiento.Value = user.BirthDate;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (User.HashPassword(txtPassword.Text) == user.Password)
            {
                txtPassword.BackColor = Color.Green;
                btnModificar.Enabled = true;
            }
            else
            {
                txtPassword.BackColor = Color.Red;
                btnModificar.Enabled = true;
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                user.IdCard = txtIdCard.Text;
                user.Name = txtName.Text;
                user.Email = txtEmail.Text;
                user.PhoneNumber = txtPhoneNumber.Text;
                user.BirthDate = dtpFechaNacimiento.Value;

                await User.ModifyUser(user);
                MessageBox.Show("Tus datos fueron modificados exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar los datos: {ex.Message}");
            }
        }
    }
}
