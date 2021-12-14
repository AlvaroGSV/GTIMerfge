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
    public partial class frmAltaComputadora : Form
    {
        ListComputer LC = new ListComputer();
        public frmAltaComputadora()
        {
            InitializeComponent();
        }

        public bool validaid()
        {
            bool val = false;
            string nom = textBox1.Text;
            if (nom.Equals(""))
            {
                errorP.SetError(textBox1, "INGRESE EL PROCESADOR");
                val = true;
            }
            return val;
        }

        public bool validaEdificio()
        {
            bool val = false;
            string nom = comboBox1.Text;
            if (nom.Equals(""))
            {
                errorP.SetError(comboBox1, "INGRESE EL PROCESADOR");
                val = true;
            }
            return val;
        }

        public bool validaRazon()
        {
            bool val = false;
            string nom = textBox4.Text;
            if (nom.Equals(""))
            {
                errorP.SetError(textBox4, "INGRESE EL PROCESADOR");
                val = true;
            }
            return val;
        }

        public bool validaMAC()
        {
            bool val = false;
            string nom = textBox3.Text;
            if (nom.Equals(""))
            {
                errorP.SetError(textBox3, "INGRESE EL PROCESADOR");
                val = true;
            }
            return val;
        }

        public bool validaAULA()
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

        public bool validaSOFT()
        {
            bool val = false;
            string nom = textBox2.Text;
            if (nom.Equals(""))
            {
                errorP.SetError(textBox2, "INGRESE EL PROCESADOR");
                val = true;
            }
            return val;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltaComputadora_Load(object sender, EventArgs e)
        {

        }

        private void btnInfraestructura_Click(object sender, EventArgs e)
        {
            string ID = textBox1.Text;
            string EDIFICIO = comboBox1.Text;
            string RAZON = textBox4.Text;
            string MAC = textBox3.Text;
            string AULA = comboBox3.Text;
            string SOFT = textBox2.Text;

            textBox1.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            comboBox1.Text = " ";
            comboBox3.Text = " ";
            textBox2.Text = " ";
            LC.Agregarcomputer(ID,AULA,null,SOFT, null, null, MAC, EDIFICIO,RAZON);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
