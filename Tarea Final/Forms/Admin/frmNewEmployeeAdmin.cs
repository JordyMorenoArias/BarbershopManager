using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client.NativeInterop;
using Microsoft.Win32;
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
    public partial class frmNewEmployeeAdmin : Form
    {
        private Employee employee { get; set; } = new Employee();
        private User user { get; set; }

        public frmNewEmployeeAdmin(User user)
        {
            InitializeComponent();
            this.user = user;
            cmbCedula.Text = user.IdCard;
            LoadDataUser(user);
            LoadCmbUsersIdCard();
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

        private void LoadDataUser(User user)
        {
            lblName.Text = user.Name;
            lblEmail.Text = user.Email;
            lblPhoneNumber.Text = user.PhoneNumber;
            lblBirthDate.Text = user.BirthDate.ToString("dd/MM/yyyy");
        }

        private void frmNewEmployeeAdmin_Load(object sender, EventArgs e)
        {

        }

        private async void cmbCedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            User user = await User.GetUserByIdCard(cmbCedula.Text);
            this.user = user;
            LoadDataUser(user);
            cmbPosition.Text = "";
            lblSalary.Text = "Salary";
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbPosition.Text)
            {
                case "Recepcionista":
                    {
                        lblSalary.Text = "$446 USD";
                        employee.Position = "Recepcionista";
                        employee.Salary = 446;
                        break;
                    }
                case "Barbero/a":
                    {
                        lblSalary.Text = "$950 USD";
                        employee.Position = "Barbero/a";
                        employee.Salary = 950;
                        break;
                    }
            }
        }

        private async void btnContratar_Click(object sender, EventArgs e)
        {
            try
            {
                employee.UserId = user.UserId;
                employee.Hiredate = DateTime.Now;
                employee.Status = true;

                await Employee.CreateEmployee(employee);
                cmbPosition.Text = "";
                lblSalary.Text = "Salary";
                MessageBox.Show("El Usuario fue contratado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error al registrar el empleado: {ex.Message}");
            }
        }
    }
}
