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

        softConfig(int IDCONFIG, int IDSOFT)
        {
            idConfig = IDCONFIG;
            idSoftware = IDSOFT;
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
    }
}
