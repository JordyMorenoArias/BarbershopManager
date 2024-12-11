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
    public partial class frmNuevoEmpleado : Form
    {
        public frmNuevoEmpleado()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombreCompleto.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            dtmNacimiento.Text = "";
            cmbSexo.Text = "";
            txtEdad.Clear();
            txtcedula.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
