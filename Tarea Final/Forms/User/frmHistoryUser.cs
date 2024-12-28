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
    public partial class frmHistoryUser : Form
    {
        private User user { get; set; }

        public frmHistoryUser(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private async void Historial_Load(object sender, EventArgs e)
        {
            if (user.IsAdmin)
                dgvHistory.Columns["ColumnUserId"].Visible = true;

            try
            {
                // Fetch histories asynchronously
                List<History> histories = await History.GetHistoriesByUser(user);

                // Order histories by ActionDate
                histories = histories.OrderByDescending(h => h.ActionDate).ToList();

                // Clear existing rows
                dgvHistory.Rows.Clear();

                // Add rows to DataGridView
                foreach (History history in histories)
                {
                    dgvHistory.Rows.Add(
                        history.HistoryId,
                        history.UserId,
                        history.TableName,
                        history.Action,
                        history.ActionDate,
                        history.Details
                    );
                }
            }
            catch (Exception ex)
            {
                // Log the exception (consider using a logging framework)
                Console.WriteLine(ex.ToString());

                // Show error message to the user
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Implement search functionality here
        }
    }
}
