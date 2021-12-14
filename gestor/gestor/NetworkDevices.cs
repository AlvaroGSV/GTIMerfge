using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class NetworkDevices
    {
        int deviceID, idNetwork, networkType, exposure, aulaNum;
        string edificio;

        NetworkDevices(int DeviceID, int IDNET, int NETTYPE, int Exposure, int AULANUM, string EDIFICIO)
        {
            deviceID = DeviceID;
            idNetwork = IDNET;
            networkType = NETTYPE;
            exposure = Exposure;
            aulaNum = AULANUM;
            edificio = EDIFICIO;
        }

        public int pdeviceID
        {
            get
            {
                return deviceID;
            }
            set
            {
                deviceID = value;
            }
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
        public int pexposure
        {
            get
            {
                return exposure;
            }
            set
            {
                exposure = value;
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

    }
}
