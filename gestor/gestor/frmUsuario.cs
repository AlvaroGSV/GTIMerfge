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
    public partial class frmUsuario : Form
    {
        ListUsuarios usuario;
        usuarios user;
        public frmUsuario(ListUsuarios users)
        {
            InitializeComponent();
            usuario = users;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnInfraestructura_Click(object sender, EventArgs e)
        {
            int tipoUsuario = 5;
            if (cmbUset.Text == "USUARIO NORMAL")
            {
                tipoUsuario = 1;
            }
            else if (cmbUset.Text == "TECNICO")
            {
                tipoUsuario = 0;
            }
            else if (cmbUset.Text == "ADMINISTRADOR")
            {
                tipoUsuario = 2;
            }

            string nUsuario = txtNUsuario.Text;
            string primerNombre = txtPName.Text;
            string segundoNombre = txtSName.Text;
            string primerApellido = txtpApellido.Text;
            string segundoApellido = txtSApellido.Text;
            string passkey = txtPass.Text;


            user = new usuarios(nUsuario,primerNombre,segundoNombre,primerApellido,segundoApellido,passkey,tipoUsuario);
            usuario.Agregar(user);
        }
    }
}
