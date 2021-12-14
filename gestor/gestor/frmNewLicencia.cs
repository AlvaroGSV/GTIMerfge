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
    public partial class frmNewLicencia : Form
    {
        ListLicencias licencias;
        ListaSoftware listaSoftware;
        licencia licencia;
        software software;
        public frmNewLicencia(ListLicencias lic, ListaSoftware listSoftware)
        {
            InitializeComponent();
            licencias = lic;
            listaSoftware = listSoftware;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfraestructura_Click(object sender, EventArgs e)
        {
            int use = 0;
            if (rdbSi.Checked == true) 
            { 
                use = 1;
            }
            int idLicencia = Convert.ToInt32(txtId.Text.ToString());
            int idSoftware = listaSoftware.getByName(comboBox1.Text.ToString());
            int ocupado = use;
            string SerialNum = txtSerial.Text.ToString();
            licencia = new licencia(idLicencia, idSoftware, ocupado, SerialNum);
            licencias.AgregarAula(licencia);
            clear();
        }

        private void frmNewLicencia_Load(object sender, EventArgs e)
        {
            List<string> nSoft = listaSoftware.getSoftNames();
            for (int i = 0; i < nSoft.Count; i++) 
            {
                comboBox1.Items.Add(nSoft[i]);
            }
            int id = licencias.getLastId() +1;
            txtId.Text=id.ToString();
        }
        private void clear()
        {
            txtId.Text = newId().ToString();
            txtSerial.Text = "";
            comboBox1.Text = "";
        }
        private int newId()
        {
            int id = licencias.getLastId() + 1;
            return id;

        }
    }
}
