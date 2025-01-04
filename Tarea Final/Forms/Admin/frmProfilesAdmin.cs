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

namespace Tarea_Final.Forms.Admin
{
    public partial class frmProfilesAdmin : Form
    {
        private User user { get; set; } = null!;
        public frmProfilesAdmin(User user)
        {
            InitializeComponent();
            LoadCmbUsersIdCard();
            this.user = user;
            LoadDataUser(user);
            cmbCedula.Text = user.IdCard;
        }

        private async void LoadCmbUsersIdCard()
        {
            string query = "SELECT IdCard FROM Users";
            try
            {
                using (SqlConnection connection = Connection.Connect())
                {
                    await connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                cmbCedula.Items.Add(reader["IdCard"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}");
            }
        }

        private async void cmbCedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            user = await User.GetUserByIdCard(cmbCedula.Text);
            LoadDataUser(user);
        }

        private void LoadDataUser(User user)
        {
            lblName.Text = user.Name;
            lblEmail.Text = user.Email;
            lblPhoneNumber.Text = user.PhoneNumber;
            lblBirthDate.Text = user.BirthDate.ToString("dd/MM/yyyy");
        }
    }
}
