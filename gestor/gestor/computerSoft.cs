using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class computerSoft
    {
        int idSoft, sistemaOperativo, Navegador, deepFreze, idConfig;
        string BIOSname, BIOSverson;

        computerSoft(int IDSOFT, int SO, int NAVEGADOR, int DEEPFREZE, int IDCONFIG, string BIOSN, string BIOSV)
        {
            idSoft = IDSOFT;
            sistemaOperativo = SO;
            Navegador = NAVEGADOR;
            deepFreze = DEEPFREZE;
            idConfig = IDCONFIG;
            BIOSname = BIOSN;
            BIOSverson = BIOSV;
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

        public int psistemaOperativo
        {
            get
            {
                return sistemaOperativo;
            }
            set
            {
                sistemaOperativo = value;
            }
        }

        public int pNavegador
        {
            get
            {
                return Navegador;
            }
            set
            {
                Navegador = value;
            }
        }
        public int pdeepFreze
        {
            get
            {
                return deepFreze;
            }
            set
            {
                deepFreze = value;
            }
        }
        public int pidConfig
        {
            get
            {
                return idConfig;
            }
            set
            {
                idConfig = value;
            }
        }
        public string pBIOSname
        {
            get
            {
                return BIOSname;
            }
            set
            {
                BIOSname = value;
            }
        }
        public string pBIOSverson
        {
            get
            {
                return BIOSverson;
            }
            set
            {
                BIOSverson = value;
            }
        }
    }
}
