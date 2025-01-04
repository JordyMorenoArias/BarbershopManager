using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_Final.Models;

namespace Tarea_Final
{
    public partial class frmConsultEmployeeAdmin : Form
    {
        private Employee employee { get; set; } = new Employee();

        public frmConsultEmployeeAdmin()
        {
            InitializeComponent();
            LoadCmbUsersIdCard();
        }

        private async void LoadCmbUsersIdCard()
        {
            string query = "SELECT u.IdCard FROM Employees e JOIN Users u ON e.UserId = u.UserId";
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
            lblName.Text = employee.Name;
            lblEmail.Text = employee.Email;
            lblPhoneNumber.Text = employee.PhoneNumber;
            lblBirthDate.Text = employee.BirthDate.ToString("dd/MM/yyyy");
            cmbPosition.Text = employee.Position;
            lblSalary.Text = $"${employee.Salary.ToString()} USD";
            lblStatus.Text = employee.Status ? "Activo" : "Inactivo";
            btnDepedirOrRecontratar.Text = employee.Status ? "Despedir" : "Recontratar";
            txtBono.Text = "";
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (employee is not null)
            {
                await Employee.ModifyEmployee(employee);
            }
            else
            {
                MessageBox.Show("Selecciona un empleado para poder modificarlo");
            }
        }

        private async void cmbCedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            employee = await Employee.GetEmployeeByIdCard(cmbCedula.Text);
            LoadDataUser(employee);
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void btnDepedirOrRecontratar_Click(object sender, EventArgs e)
        {
            if (employee is not null)
            {
                try
                {
                    switch (btnDepedirOrRecontratar.Text)
                    {
                        case "Despedir":
                            {
                                employee.Status = false;
                                await Employee.ModifyEmployee(employee);
                                if(employee.Position == "Barbero/a")
                                {
                                    await CancelEmployeeAppointments(employee);
                                    MessageBox.Show($"El empleado {employee.Name} fue despedido y todas su citas fueron canceladas");
                                }
                                else
                                {
                                    MessageBox.Show($"El empleado {employee.Name} fue despedido");
                                }
                                LoadDataUser(employee);

                                break;
                            }
                        case "Recontratar":
                            {
                                employee.Status = true;
                                await Employee.ModifyEmployee(employee);
                                MessageBox.Show($"El empleado {employee.Name} fue recontratado exitosamente");
                                LoadDataUser(employee);
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ha ocurrido un error al intentar {btnDepedirOrRecontratar.Text} al usuario {employee.Name}: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Todavia no has seleccionado a un empleado");
            }

        }

        private async Task CancelEmployeeAppointments(Employee employee)
        {
            using (SqlConnection connection = Connection.Connect())
            {
                await connection.OpenAsync();

                string query = @"UPDATE Appointments SET Status = 'Cancelada' WHERE EmployeeId = @EmployeeId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeId", employee.IdEmployee);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
