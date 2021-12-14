using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class computer
    {
        string idCompu, aulaNum, numIncidentes, softwareEspecializado, idHard, idSoft,addressMAC, edificio, razonUso;

        public computer(string IDCOMPU, string AULANUM, string NUMINCI, string SOFTESP, string IDHARD, string IDSOFT, string ADDMAC, string EDIFICIO, string RAZONUSO)
        {
            idCompu = IDCOMPU;
            aulaNum = AULANUM;
            numIncidentes = NUMINCI;
            softwareEspecializado = SOFTESP;
            idHard = IDHARD;
            idSoft = IDSOFT;
            addressMAC = ADDMAC;
            edificio = EDIFICIO;
            razonUso = RAZONUSO;
        }

        public string pidCompu
        {
            get
            {
                return idCompu;
            }
            set
            {
                idCompu = value;
            }
        }
        public string paulaNum
        {
            get
            {
                return aulaNum;
            }
            set
            {
                aulaNum = value;
            }
        }
        public string pnumIncidentes
        {
            get
            {
                return numIncidentes;
            }
            set
            {
                numIncidentes = value;
            }
        }
        public string psoftwareEspecializado
        {
            get
            {
                return softwareEspecializado;
            }
            set
            {
                softwareEspecializado = value;
            }
        }
        public string pidHard
        {
            get
            {
                return idHard;
            }
            set
            {
                idHard = value;
            }
        }
        public string pidSoft
        {
            get
            {
                return idSoft;
            }
            set
            {
                idSoft = value;
            }
        }
        public string paddressMAC
        {
            get
            {
                return addressMAC;
            }
            set
            {
                addressMAC = value;
            }
        }
        public string pedificio
        {
            get
            {
                return edificio;
            }
            set
            {
                edificio = value;
            }
        }
        public string prazonUso
        {
            get
            {
                return razonUso;
            }
            set
            {
                razonUso = value;
            }
        }
    }
}
