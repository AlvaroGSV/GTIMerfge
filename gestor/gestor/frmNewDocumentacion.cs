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
    public partial class frmNewDocumentacion : Form
    {
        ListDocumentacion document;
        documentacion newDocumentacion;
        public frmNewDocumentacion(ListDocumentacion listDocumentacion)
        {
            InitializeComponent();
            document = listDocumentacion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfraestructura_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text.ToString());
            string archivoManual = textBox2.Text;
            string archivoGarantia = textBox3.Text;
            int garantia = 0;
            int manual = 0;
            if (rdbSiGarantia.Checked) 
            {
                garantia = 1;
            }
            if (rdbSiManual.Checked) 
            {
                manual = 1;
            }
            newDocumentacion = new documentacion(id,manual,garantia,archivoManual,archivoGarantia);
            document.AgregarDocumentacion(newDocumentacion);
            clean();
            int sum = document.getNumDocumentos() + 1;
            textBox1.Text = sum.ToString();
        }

        private void frmNewDocumentacion_Load(object sender, EventArgs e)
        {
            int id = document.getNumDocumentos() + 1;
            textBox1.Text = id.ToString();
        }

        private void clean() 
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
