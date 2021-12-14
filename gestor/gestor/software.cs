using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class software
    {
        private int idSoftware, SO;
        private string nombre, desarrollador, version, pesoMb;

        software(int ID, int so, string NombreS, string DeSa, string Version, string Peso)
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

        public int pso
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
