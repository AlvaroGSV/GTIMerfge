using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class licencia
    {
        int idLicencia, idSoftware, ocupado;
        string SerialNum;
        public licencia(int IDLIC, int IDSOFT, int OCUPADO, string SerianNUM)
        {
            idLicencia = IDLIC;
            idSoftware = IDSOFT;
            ocupado = OCUPADO;
            SerialNum = SerianNUM;
        }

        public int pidLicencia
        {
            get
            {
                return idLicencia;
            }
            set
            {
                idLicencia = value;
            }
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

        public int pocupado
        {
            get
            {
                return ocupado;
            }
            set
            {
                ocupado = value;
            }
        }

        public string pSerialNum
        {
            get
            {
                return SerialNum;
            }
            set
            {
                SerialNum = value;
            }
        }
    }
}

