using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestor
{
    public partial class UsuarioNormal : Form
    {
        List<string> list;
        public UsuarioNormal(List<string> listLogged)
        {
            InitializeComponent();
            list=listLogged;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿DESEA CERRAR SESION?", "CERRAR VENTANA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes))
            {
                this.Close();
            }
        }

        private void btnNewReport_Click(object sender, EventArgs e)
        {
            NuevoReporte newReport = new NuevoReporte();
            newReport.Show();
        }

        private void UsuarioNormal_Load(object sender, EventArgs e)
        {
        }
    }
}
