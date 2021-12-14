using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class Network
    {
        int idNetwork, networkType;
        string networkName, netowrkSpeedMB;

        Network(int IDNET, int NETTYPE, string NETNAME, string NETSPEED)
        {
            idNetwork = IDNET;
            networkType = NETTYPE;
            networkName = NETNAME;
            netowrkSpeedMB = NETSPEED;
        }

        public int pidNetwork
        {
            get
            {
                return idNetwork;
            }
            set
            {
                idNetwork = value;
            }
        }
        public int pnetworkType
        {
            get
            {
                return networkType;
            }
            set
            {
                networkType = value;
            }
        }
        public string pnetworkName
        {
            get
            {
                return networkName;
            }
            set
            {
                networkName = value;
            }
        }
        public string pnetowrkSpeedMB
        {
            get
            {
                return netowrkSpeedMB;
            }
            set
            {
                netowrkSpeedMB = value;
            }
        }
    }
}
