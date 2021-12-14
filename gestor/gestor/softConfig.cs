using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class softConfig
    {
        int idConfig, idSoftware;
        string nomConfig;

        public softConfig(int IDCONFIG, int IDSOFT, string nom)
        {
            idConfig = IDCONFIG;
            idSoftware = IDSOFT;
            nomConfig = nom;
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
        public string pNomConfig 
        { 
            get 
            { return nomConfig; } 
            set 
            { nomConfig = value; } 
        }
    }
}
