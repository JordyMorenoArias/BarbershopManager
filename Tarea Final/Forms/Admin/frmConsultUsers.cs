using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class frmConsultUsers : Form
    {
        private User user { get; set; }

        public frmConsultUsers()
        {
            InitializeComponent();
            LoadCmbUsersEmail();
        }

        private async void LoadCmbUsersEmail()
        {
            string query = "SELECT Email FROM Users";
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
                                cmbEmail.Items.Add(reader["Email"].ToString());
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private async void cmbEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmail.Text != "")
                {
                    user = await User.GetuserByEmail(cmbEmail.Text);

                    if (user != null)
                    {
                        txtName.Text = user.Name;
                        txtIdCard.Text = user.IdCard;
                        txtPhoneNumber.Text = user.PhoneNumber;
                        txtIsAdmin.Text = user.IsAdmin ? "Si lo Es" : "No lo Es";

                        List<History> histories = await History.GetHistoriesByUser(user);
                        histories = histories.OrderBy(h => h.ActionDate).ToList();

                        foreach (History history in histories)
                        {
                            dvgHistory.Rows.Add(history.HistoryId,
                                                history.Action,
                                                history.ActionDate,
                                                history.Details);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos del usuarios: {ex.Message}");
            }
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbEmail.Text != "")
                {
                    user.Name = txtName.Text;
                    user.IdCard = txtIdCard.Text;
                    user.PhoneNumber = txtPhoneNumber.Text;
                    user.IsAdmin = txtIsAdmin.Text == "Si lo Es" ? true : false;

                    await User.ModifyUser(user);
                    MessageBox.Show("El usuario ha sido modificado correctamente.", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Selecciona al usuario que quieres consultar los cambios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al intentar modificar al usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
