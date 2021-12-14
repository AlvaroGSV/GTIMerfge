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
        public UsuarioAdmin()
        {
            InitializeComponent();
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
            TfrmInfraestrucutra infraestrucutra = new TfrmInfraestrucutra();
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
            frmUsuario usuario = new frmUsuario();
            usuario.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmOtrosDispositivos otrosDispositivos = new frmOtrosDispositivos();
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
            frmNewDocumentacion newDocumentacion = new frmNewDocumentacion();
            newDocumentacion.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNewSoftware software = new frmNewSoftware();
            software.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmNewLicencia frmNewLicencia = new frmNewLicencia();
            frmNewLicencia.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAltaSoftConfig frmAltaSoftConfig = new frmAltaSoftConfig(); 
            frmAltaSoftConfig.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmAltaCompuSoft altaCompuSoft = new frmAltaCompuSoft();
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
    }
}
