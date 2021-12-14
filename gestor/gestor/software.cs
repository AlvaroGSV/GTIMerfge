using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class software
    {
        private int idSoftware;
        private string nombre, desarrollador, version, pesoMb, SO;

        public software(int ID, string so, string NombreS, string DeSa, string Version, string Peso)
        {
            idSoftware = ID;
            SO = so;
            nombre = NombreS;
            desarrollador = DeSa;
            version = Version;
            pesoMb = Peso;
        }

        public int pidSoftware
        {
            get
            {
                return idSoftware;
            }
            set
            {
                idSoftware = value;
            }
        }

        public string pso
        {
            get
            {
                return SO;
            }
            set
            {
                SO = value;
            }
        }

        public string pnombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string pdesarrollador
        {
            get
            {
                return desarrollador;
            }
            set
            {
                desarrollador = value;
            }
        }

        public string pversion
        {
            get
            {
                return version;
            }
            set
            {
                version = value;
            }
        }

        public string ppesoMb
        {
            get
            {
                return pesoMb;
            }
            set
            {
                pesoMb = value;
            }
        }

    }


}
