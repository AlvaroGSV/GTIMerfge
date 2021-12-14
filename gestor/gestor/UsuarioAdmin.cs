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
    public partial class UsuarioAdmin : Form
    {
        ListDocumentacion document;
        ListaSoftware listaSoftware;
        ListLicencias licencias;
        ListSoftConfig listSoftConfig;
        ListComputerSoft listComputerSoft;
        ListaEdificios listaEdificio;
        ListaAula listaAula;
        ListUsuarios user;
        ListOtrosDispositivos listOtrosDispositivos;
        public UsuarioAdmin(ListDocumentacion listDocumentacion, ListaSoftware listSoftware, ListLicencias lic, ListSoftConfig listSoft, ListComputerSoft listComputerSof, ListaEdificios ListaEdificio, ListaAula listaaula, ListUsuarios usuario, ListOtrosDispositivos od)
        {
            InitializeComponent();
            document = listDocumentacion;
            listaSoftware = listSoftware;
            licencias = lic;
            listSoftConfig = listSoft;
            listComputerSoft = listComputerSof;
            listaEdificio = ListaEdificio;
            listaAula = listaaula;
            user = usuario;
            listOtrosDispositivos = od;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿DESEA CERRAR SESION?", "CERRAR VENTANA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes))
            {
                this.Close();
            }
        }

        private void btnInfraestructura_Click(object sender, EventArgs e)
        {
            TfrmInfraestrucutra infraestrucutra = new TfrmInfraestrucutra(listaEdificio, listaAula);
            infraestrucutra.Show();
        }

        private void btnNetDev_Click(object sender, EventArgs e)
        {
            frmNuevoDispositivoRed dispositivoRed = new frmNuevoDispositivoRed();
            dispositivoRed.Show();
        }

        private void btnRedes_Click(object sender, EventArgs e)
        {
            frmNuevaRed nuevaRed = new frmNuevaRed();
            nuevaRed.Show();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            frmCategoria categoria = new frmCategoria();
            categoria.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            frmInventario inventario = new frmInventario();
            inventario.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmUsuario usuario = new frmUsuario(user);
            usuario.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmOtrosDispositivos otrosDispositivos = new frmOtrosDispositivos(document, listOtrosDispositivos, listaAula, listaEdificio);
            otrosDispositivos.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmNewServicio newServicio = new frmNewServicio();
            newServicio.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmNewStepService stepService = new frmNewStepService();
            stepService.Show();
        }

        private void btnDocumentacion_Click(object sender, EventArgs e)
        {
            frmNewDocumentacion newDocumentacion = new frmNewDocumentacion(document);
            newDocumentacion.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNewSoftware software = new frmNewSoftware(listaSoftware);
            software.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmNewLicencia frmNewLicencia = new frmNewLicencia(licencias, listaSoftware);
            frmNewLicencia.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAltaSoftConfig frmAltaSoftConfig = new frmAltaSoftConfig(listSoftConfig, listaSoftware); 
            frmAltaSoftConfig.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmAltaCompuSoft altaCompuSoft = new frmAltaCompuSoft(listComputerSoft, listSoftConfig);
            altaCompuSoft.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmNewComputerHard soft = new frmNewComputerHard();
            soft.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmAltaComputadora altaComputadora = new frmAltaComputadora();
            altaComputadora.Show();
        }

        private void UsuarioAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
