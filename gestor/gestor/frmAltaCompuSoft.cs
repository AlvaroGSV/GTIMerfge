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
    public partial class frmAltaCompuSoft : Form
    {
        ListComputerSoft listComputerSoft;
        ListSoftConfig softConfig;
        computerSoft computer;
        public frmAltaCompuSoft(ListComputerSoft listComputerSot, ListSoftConfig softConf)
        {
            InitializeComponent();
            listComputerSoft = listComputerSot;
            softConfig = softConf;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnInfraestructura_Click(object sender, EventArgs e)
        {
            int opFreze = 0;
            if (rdbSI.Checked == true)
            {
                opFreze = 1;
            }
            int idSoft = Convert.ToInt32(txtID.Text);
            string sistemaOperativo = cmbSO.Text;
            string Navegador = cmbNavegador.Text;
            int deepFreze = opFreze;
            int idConfig = softConfig.getByName(cmbConfiguraciones.Text);
            string BIOSname = txtNameBios.Text;
            string BIOSverson = txtVerBios.Text;
            computer = new computerSoft(idSoft,sistemaOperativo,Navegador,deepFreze,idConfig,BIOSname,BIOSverson);
            clear();
        }

        private void frmAltaCompuSoft_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list = softConfig.getSoftNames();
            for (int i = 0; i < list.Count; i++)
            {
                cmbConfiguraciones.Items.Add(list[i].ToString());
            }
            txtID.Text = GetId().ToString();
        }
        private int GetId()
        {
            int id = 0;
            id = listComputerSoft.getLastId() + 1;
            return id;
        }
        private void clear() 
        {
            txtID.Text = "";
            txtNameBios.Text = "";
            txtVerBios.Text = "";
            cmbConfiguraciones.Text = "";
            cmbNavegador.Text = "";
            cmbSO.Text = "";
            txtID.Text = GetId().ToString();
        }
    }
}
