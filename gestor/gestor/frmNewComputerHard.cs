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
    public partial class frmNewComputerHard : Form
    {
        ListComputerHard CH = new ListComputerHard();
        public frmNewComputerHard()
        {
            InitializeComponent();
        }
        public bool validaHard()
        {
            bool val = false;
            string nom = textBox1.Text;
            if (nom.Equals(""))
            {
                errorP.SetError(textBox1, "INGRESE EL ID DE LA CONFIGURACION");
                val = true;
            }
            return val;
        }

        public bool validastSV()
        {
            bool val = false;
            string nom = comboBox2.Text;
            if (nom.Equals(""))
            {
                errorP.SetError(comboBox2, "INGRESE SALIDA DE VIDEO");
                val = true;
            }
            return val;
        }
        public bool validaSA()
        {
            bool val = false;
            string nom = comboBox1.Text;
            if (nom.Equals(""))
            {
                errorP.SetError(comboBox1, "INGRESE  SALIDA DE AUDIO");
                val = true;
            }
            return val;
        }

        public bool validaF()
        {
            bool val = false;
            string nom = textBox6.Text;
            if (nom.Equals(""))
            {
                errorP.SetError(textBox6, "INGRESE FAMILIA DEL PROCESADOR");
                val = true;
            }
            return val;
        }

        public bool validaV()
        {
            bool val = false;
            string nom = comboBox4.Text;
            if (nom.Equals(""))
            {
                errorP.SetError(comboBox4, "INGRESE SELECCIONE UNA OPCION");
                val = true;
            }
            return val;
        }

        public bool validaM()
        {
            bool val = false;
            string nom = textBox5.Text;
            if (nom.Equals(""))
            {
                errorP.SetError(textBox5, "INGRESE MODELO DE TARJETA MADRE");
                val = true;
            }
            return val;
        }
        public bool validaP()
        {
            bool val = false;
            string nom = comboBox3.Text;
            if (nom.Equals(""))
            {
                errorP.SetError(comboBox3, "INGRESE EL PROCESADOR");
                val = true;
            }
            return val;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewComputerHard_Load(object sender, EventArgs e)
        {

        }

        private void btnInfraestructura_Click(object sender, EventArgs e)
        {
            string Hard = textBox1.Text;
            string salidaV = comboBox2.Text;
            string salidaA = comboBox1.Text;
            string famili = textBox6.Text;
            string procesador = comboBox3.Text;
            string ventilador = comboBox4.Text;
            string tarjeta = textBox5.Text;

            textBox1.Text = " ";
            textBox6.Text = " ";
            textBox5.Text = " ";
            CH.AgregarHard(Hard, salidaV, salidaA, famili, ventilador,procesador, tarjeta);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
