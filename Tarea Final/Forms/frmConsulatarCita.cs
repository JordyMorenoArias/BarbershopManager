using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
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
    public partial class frmConsulatarCita : Form
    {

        public frmConsulatarCita()
        {
            InitializeComponent();
        }

        private void ConsulatarCita_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Cita Modificada");

            txtcedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            dtpFecha.Text = "";
            dtpHora.Text = "";
            cmbBarberos.Text = "";
            cmbStatus.Text = "";

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
