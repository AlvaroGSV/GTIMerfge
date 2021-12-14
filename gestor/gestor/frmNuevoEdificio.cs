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
    public partial class frmNuevoEdificio : Form
    {
        edificio Edificio;
        ListaEdificios listaEdificio;
        public frmNuevoEdificio(ListaEdificios ListaEdificio)
        {
            InitializeComponent();
            listaEdificio = ListaEdificio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfraestructura_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            string nom = txtNom.Text;
            Edificio = new edificio(id, nom);
            listaEdificio.AgregarEdificio(Edificio);
        }
    }
}
