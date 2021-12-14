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
    public partial class frmNewSoftware : Form
    {
        ListaSoftware listaSoftware;
        software soft;
        public frmNewSoftware(ListaSoftware listSoftware)
        {
            InitializeComponent();
            listaSoftware = listSoftware;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfraestructura_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text.ToString());
            string name = txtName.Text.ToString();
            string dev = txtDev.Text.ToString();
            string ver = txtVer.Text.ToString();
            string so = cmbSO.Text.ToString();
            string mb = txtMb.Text.ToString();
            soft = new software(id,so,name,dev,ver,mb);
            listaSoftware.AgregarSoftware(soft);
            clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmNewSoftware_Load(object sender, EventArgs e)
        {
            txtId.Text = getId().ToString();
        }
        private int getId() 
        {
            int id = listaSoftware.getLastId() + 1;
            return id;
        }
        private void clear()
        {
            txtDev.Text = "";
            txtId.Text = "";
            txtMb.Text = "";
            txtName.Text = "";
            txtVer.Text = "";
            cmbSO.Text = "";
            txtId.Text = getId().ToString();
        }
    }
}
