using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class computer
    {
        int idCompu, aulaNum, numIncidentes, softwareEspecializado, idHard, idSoft;
        string addressMAC, edificio, razonUso;

        computer(int IDCOMPU, int AULANUM, int NUMINCI, int SOFTESP, int IDHARD, int IDSOFT, string ADDMAC, string EDIFICIO, string RAZONUSO)
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

        public int pidCompu
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
        public int paulaNum
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
        public int pnumIncidentes
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
        public int psoftwareEspecializado
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
        public int pidHard
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
        public int pidSoft
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
