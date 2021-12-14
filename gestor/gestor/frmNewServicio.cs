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
    public partial class frmNewServicio : Form
    {
        ListServiciosTecncicos LST = new ListServiciosTecncicos();
        public frmNewServicio()
        {
            InitializeComponent();
        }
        public bool validaNumS()
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

        public bool validaNomS()
        {
            bool val = false;
            string nom = textBox2.Text;
            if (nom.Equals(""))
            {
                errorP.SetError(textBox2, "INGRESE EL ID DE LA CONFIGURACION");
                val = true;
            }
            return val;
        }

        public bool validaTE()
        {
            bool val = false;
            string nom = textBox4.Text;
            if (nom.Equals(""))
            {
                errorP.SetError(textBox4, "INGRESE EL ID DE LA CONFIGURACION");
                val = true;
            }
            return val;
        }

        public bool validadesc()
        {
            bool val = false;
            string nom = textBox3.Text;
            if (nom.Equals(""))
            {
                errorP.SetError(textBox3, "INGRESE EL ID DE LA CONFIGURACION");
                val = true;
            }
            return val;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewServicio_Load(object sender, EventArgs e)
        {

        }

        private void btnInfraestructura_Click(object sender, EventArgs e)
        {
            string NumS = textBox1.Text;
            string NomS = textBox2.Text;
            string Desc= textBox3.Text;
            string TE= textBox4.Text;

            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";

            LST.AgregarST(NumS, TE, NomS, Desc);
        }
    }
}
