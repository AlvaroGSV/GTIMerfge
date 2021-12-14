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
    public partial class frmOtrosDispositivos : Form
    {
        ListOtrosDispositivos dispositivos;
        ListDocumentacion document;
        ListaAula aula;
        ListaEdificios edificios;
        otrosDispositivos oDisp;
        public frmOtrosDispositivos(ListDocumentacion listDocumentacion, ListOtrosDispositivos listOtros, ListaAula listaAula, ListaEdificios listaEdificios)
        {
            InitializeComponent();
            document = listDocumentacion;
            dispositivos = listOtros;
            aula = listaAula;
            edificios = listaEdificios;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNewDocumentacion newDocumentacion = new frmNewDocumentacion(document);
            newDocumentacion.Show();
        }

        private void frmOtrosDispositivos_Load(object sender, EventArgs e)
        {
            List<edificio> build = edificios.GetAll();
            List<documentacion> docu = document.GetAll();
            for(int i= 0; i < build.Count; i++)
            {
                cmbEdificio.Items.Add(build[i].Text.ToString());
            }
            for (int i = 0; i < docu.Count; i++)
            {
                cmbAula.Items.Add(docu[i].pidDocumentacion.ToString());
            }
            txtId.Text = getId().ToString();
        }

        private void btnInfraestructura_Click(object sender, EventArgs e)
        {
            int aulaNum=0;
            List<edificio> build = edificios.GetAll();
            List<aula> lista = aula.GetAll();
            for (int i = 0;i < lista.Count; i++)
            {
                if (lista[i].pidEdificio == cmbEdificio.Text)
                {
                    aulaNum = lista[i].aulaNum;
                }
            }
            

            int idDocumentacion = Convert.ToInt32(cmbDocumentacion.Text);
            int tiempoVida = 0;
            int mantenimientoMinimo = Convert.ToInt32(txtTiempoMinimo.Text);
            int mantenimientoMaximo = Convert.ToInt32(txtTiempoMaximo.Text);
            int ultimoMantenimiento = 0;
            
            string idDispositivo = txtId.Text;
            string nombre = txtName.Text; 
            string edificioSTop = cmbEdificio.Text;

            oDisp = new otrosDispositivos(idDispositivo,idDocumentacion,tiempoVida,mantenimientoMinimo,mantenimientoMaximo,ultimoMantenimiento,aulaNum,nombre,edificioSTop);
            dispositivos.Agregar(oDisp);
            clear();
        }
        private int getId() 
        {
            int id = 0;
            id = dispositivos.getLastId()+1;
            return id;
        }
        private void clear()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtTiempoMaximo.Text = "";
            txtTiempoMinimo.Text = "";
            cmbAula.Text = "";
            cmbDocumentacion.Text = "";
            cmbEdificio.Text = "";
            txtId.Text = getId().ToString();
        }
    }
}
