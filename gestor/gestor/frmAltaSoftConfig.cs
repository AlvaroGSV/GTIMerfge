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
    public partial class frmAltaSoftConfig : Form
    {
        ListSoftConfig listSoftConfig;
        ListaSoftware listaSoftware;
        softConfig softconfig;
        public frmAltaSoftConfig(ListSoftConfig soft, ListaSoftware lista)
        {
            InitializeComponent();
            listSoftConfig = soft;
            listaSoftware = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltaSoftConfig_Load(object sender, EventArgs e)
        {
            txtId.Text = getId().ToString();
        }
        private int getId()
        {
            int id = 0;
            id = listSoftConfig.getLastId() + 1;
            return id;
        }

        private void btnInfraestructura_Click(object sender, EventArgs e)
        {
            int nItem = listSoft.SelectedItems.Count;
            int idConfig = Convert.ToInt32(txtId.Text.ToString());
            string nomConfig = txtNom.Text.ToString();
            List<string> items = new List<string>();
            List<int> ids = new List<int>();
            for (int i = 0; i < nItem; i++) 
            {
                items.Add(listSoft.SelectedItems[i].ToString());
            }
            for (int i = 0;i < items.Count; i++) 
            {
                ids.Add(listaSoftware.getByName(items[i].ToString()));
            }
            for(int i = 0; i < ids.Count; i++)
            {
                int idSoftware = ids[i];
                softconfig = new softConfig(idConfig, idSoftware, nomConfig);
                listSoftConfig.Agregar(softconfig);
            }
            
            
            clear();
        }
        private void clear() 
        {
            txtId.Text = "";
            txtNom.Text = "";
            cmbSO.Text = "";
            listSoft.Items.Clear();
            txtId.Text=getId().ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string so = cmbSO.Text.ToString();
            List<string> list = listaSoftware.getBySO(so);
            listSoft.Items.Clear();
            for(int i=0; i < list.Count; i++)
            {
                listSoft.Items.Add(list[i].ToString());
            }
        }

    }
}
