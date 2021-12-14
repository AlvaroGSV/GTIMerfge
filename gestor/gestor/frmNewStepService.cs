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
    public partial class frmNewStepService : Form
    {
        ListPasosDeServicioTecnicos LP = new ListPasosDeServicioTecnicos();
        public frmNewStepService()
        {
            InitializeComponent();
        }
        public bool validastepservice()
        {
            bool val = false;
            string nom = textBox1.Text;
            if (nom.Equals(""))
            {
                errorP.SetError(textBox1, "INGRESE NUMERO DE SERVICIO");
                val = true;
            }
            return val;
        }

        public bool validapaso()
        {
            bool val = false;
            string nom = textBox2.Text;
            if (nom.Equals(""))
            {
                errorP.SetError(textBox1, "INGRESE NUMERO DE PASO");
                val = true;
            }
            return val;
        }

        public bool validaDescripcion()
        {
            bool val = false;
            string nom = textBox3.Text;
            if (nom.Equals(""))
            {
                errorP.SetError(textBox1, "INGRESE NUMERO DE SERVICIO");
                val = true;
            }
            return val;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInfraestructura_Click(object sender, EventArgs e)
        {
            string servicio = textBox1.Text;
            int paso = int.Parse(textBox2.Text);
            string descripcion = textBox3.Text; 

            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            LP.Agregar(servicio, paso, descripcion);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmNewStepService_Load(object sender, EventArgs e)
        {

        }
    }
}
