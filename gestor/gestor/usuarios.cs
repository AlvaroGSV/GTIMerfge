using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class usuarios
    {
        int tipoUsuario;
        string nUsuario, primerNombre, segundoNombre, primerApellido, segundoApellido, passkey;

        public usuarios(string NUSUARIO, string primerNOMBRE, string segundoNOMBRE, string PrimerApellido, string SegundoApellido, string PASSkey, int TipoUsuario)
        {
            nUsuario = NUSUARIO;
            primerNombre = primerNOMBRE;
            segundoNombre = segundoNOMBRE;
            primerApellido = PrimerApellido;
            segundoApellido = SegundoApellido;
            passkey = PASSkey;
            tipoUsuario = TipoUsuario;
        }

        public int ptipoUsuario
        {
            get
            {
                return tipoUsuario;
            }
            set
            {
                tipoUsuario = value;
            }
        }
        public string pnUsuario
        {
            get
            {
                return nUsuario;
            }
            set
            {
                nUsuario = value;
            }
        }
        public string pprimerNombre
        {
            get
            {
                return primerNombre;
            }
            set
            {
                primerNombre = value;
            }
        }
        public string psegundoNombre
        {
            get
            {
                return segundoNombre;
            }
            set
            {
                segundoNombre = value;
            }
        }
        public string pprimerApellido
        {
            get
            {
                return primerApellido;
            }
            set
            {
                primerApellido = value;
            }
        }
        public string psegundoApellido
        {
            get
            {
                return segundoApellido;
            }
            set
            {
                segundoApellido = value;
            }
        }
        public string ppasskey
        {
            get
            {
                return passkey;
            }
            set
            {
                passkey = value;
            }
        }
    }
}
