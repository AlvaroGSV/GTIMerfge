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
    public partial class TfrmInfraestrucutra : Form
    {
        ListaEdificios listaEdificio;
        ListaAula listaAula;
        public TfrmInfraestrucutra(ListaEdificios ListaEdificio, ListaAula listaaula)
        {
            InitializeComponent();
            listaEdificio = ListaEdificio;
            listaAula = listaaula;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿DESEA CERRAR LA VENTANA?", "CERRAR VENTANA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes))
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNuevoEdificio nuevoEdificio = new frmNuevoEdificio(listaEdificio);
            nuevoEdificio.Show();
        }

        private void btnInfraestructura_Click(object sender, EventArgs e)
        {
            NuevaAula nuevaAula = new NuevaAula(listaEdificio, listaAula);
            nuevaAula.Show();
        }
    }
}
