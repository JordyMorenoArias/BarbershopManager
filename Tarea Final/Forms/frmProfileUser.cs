using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmProfileUser : Form
    {
        private Models.User user { get; set; }

        public frmProfileUser(Models.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            lblCedula.Text = user.IdCard;
            lblName.Text = user.Name;
            lblEmail.Text = user.Email;
            lblPhoneNumber.Text = user.PhoneNumber;
            lblBirthDate.Text = user.BirthDate.ToString("dd/MM/yyyy");
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
