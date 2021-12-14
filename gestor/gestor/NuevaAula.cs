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
    public partial class NuevaAula : Form
    {
        ListaEdificios listaEdificio;
        ListaAula listaAula;
        aula room;
        public NuevaAula(ListaEdificios ListaEdificio, ListaAula listaaula)
        {
            InitializeComponent();
            listaEdificio = ListaEdificio;
            listaAula = listaaula;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfraestructura_Click(object sender, EventArgs e)
        {
            string idEdificio = "";
            List<edificio> edificios = listaEdificio.GetAll();
            for (int i = 0; i < edificios.Count; i++)
            {
                if(comboBox1.Text == edificios[i].Text.ToString())
                {
                    idEdificio = edificios[i].idEdificio.ToString();
                }
            }
            int aulaNum = Convert.ToInt32(textBox2.Text.ToString());
            room = new aula(aulaNum, idEdificio);
            listaAula.Agregar(room);
        }

        private void NuevaAula_Load(object sender, EventArgs e)
        {
            List < edificio > edificios = listaEdificio.GetAll();
            for(int i = 0; i < edificios.Count; i++)
            {
                comboBox1.Items.Add(edificios[i].Text);
            }
        }
    }
}
