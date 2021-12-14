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
    public partial class FrmTecnicoxService : Form
    {
        ListTecnicoxservice Ltxs = new ListTecnicoxservice();

        public bool validatecnico()
        {
            bool val = false;
            string nom = comboBox1.Text;
            if (nom.Equals(""))
            {
                errorP.SetError(comboBox1, "SELECCIONE EL NONBRE DEL TECNICO");
                val = true;
            }
            return val;
        }

        public bool validaservicio()
        {
            bool val = false;
            string nom = comboBox2.Text;
            if (nom.Equals(""))
            {
                errorP.SetError(comboBox2, "SELECCIONE EL SERVICIO");
                val = true;
            }
            return val;
        }

        public FrmTecnicoxService()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tecnico = comboBox1.Text;
            string servicio = comboBox2.Text;

            comboBox1.Text = " ";
            comboBox2.Text = " ";
            Ltxs.agregarTxS(servicio, tecnico);
        }
    }
}
