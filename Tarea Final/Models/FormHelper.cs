using System.Windows.Forms;

namespace Tarea_Final.Helpers
{
    public static class FormHelper
    {
        public static void AbrirForm(Form container, object frm)
        {
            if (container.Controls.Count > 0)
                container.Controls.RemoveAt(0);

            Form fh = frm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            container.Controls.Add(fh);
            container.Tag = fh;
            fh.Show();
        }
    }
}
