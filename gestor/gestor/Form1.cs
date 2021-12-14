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
    public partial class Form1 : Form
    {
        ListUsuarios users;
        usuarios usuario;
        ListDocumentacion document;
        ListaSoftware listaSoftware;
        ListLicencias licencias;
        ListSoftConfig listSoftConfig;
        ListComputerSoft listComputerSoft;
        ListaEdificios listaEdificio;
        ListaAula listaAula;
        ListOtrosDispositivos otrosDispositivos;

        List<string> login;
        public Form1()
        {
            InitializeComponent();
            users = new ListUsuarios();
            document = new ListDocumentacion();
            listaSoftware = new ListaSoftware();
            licencias = new ListLicencias();
            listSoftConfig = new ListSoftConfig();
            listComputerSoft = new ListComputerSoft();
            login = new List<string>();
            listaEdificio = new ListaEdificios();
            listaAula = new ListaAula();
            otrosDispositivos = new ListOtrosDispositivos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usuario = new usuarios("18170244", "name", "name", "apellido", "apellido", "2468", 0);
            users.Agregar(usuario);
            usuario = new usuarios("18170245", "name", "name", "apellido", "apellido", "2468", 1);
            users.Agregar(usuario);
            usuario = new usuarios("18170246", "name", "name", "apellido", "apellido", "2468", 2);
            users.Agregar(usuario);
            usuario = new usuarios("18170247", "name", "name", "apellido", "apellido", "2468", 3);
            users.Agregar(usuario);
            users.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string user = txtUser.Text.ToString();
            string pass = txtPass.Text.ToString();
            login.Add(user);
            int tUser = users.LogIn(user, pass);
            if(tUser == 0) 
            {
                UsuarioTecnico tecnico = new UsuarioTecnico();
                tecnico.Show();
            }
            else if (tUser == 1)
            {
                UsuarioNormal norm = new UsuarioNormal(login);
                norm.Show();
            }
            else if(tUser == 2)
            {
                UsuarioAdmin admin = new UsuarioAdmin(document, listaSoftware, licencias, listSoftConfig, listComputerSoft, listaEdificio, listaAula, users, otrosDispositivos);
                admin.Show();
            }
            else if(tUser == 3)
            {
                UsuarioAdmin admin = new UsuarioAdmin(document, listaSoftware, licencias, listSoftConfig, listComputerSoft, listaEdificio, listaAula, users, otrosDispositivos);
                admin.Show();
            }
            else if (txtUser.Text == "111" && txtPass.Text == "111")
            {
                UsuarioTecnico tecnico = new UsuarioTecnico();
                tecnico.Show();
            }
            else if (txtUser.Text == "222" && txtPass.Text == "222")
            {
                UsuarioNormal norm = new UsuarioNormal(login);
                norm.Show();
            }
            else if (txtUser.Text == "333" && txtPass.Text == "333")
            {
                UsuarioAdmin admin = new UsuarioAdmin(document, listaSoftware, licencias, listSoftConfig, listComputerSoft, listaEdificio, listaAula, users, otrosDispositivos);
                admin.Show();
            }
            else 
            {
            }
        }
    }
}
