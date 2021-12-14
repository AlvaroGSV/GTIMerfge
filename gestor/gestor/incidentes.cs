using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class incidentes
    {
        int nIncidnete, aulaNum, esCompu, esDispositivoRed, esOtroDispositivo, idCompu, deviceID;
        string idEdificio, nUsuarioAlta, nUsuarioTecnico, idDispositivo;

        incidentes(int NINCI, int AULAN, int ESCOMPU, int ESDISRED, int ESOTRODISPO, int IDCOMPU, int DEVICEID,
            string IDEdificio, string NUSUARIOA, string NUSUARIOT, string IDDISPOSITIVO)
        {
            nIncidnete = NINCI;
            aulaNum = AULAN;
            esCompu = ESCOMPU;
            esDispositivoRed = ESDISRED;
            esOtroDispositivo = ESOTRODISPO;
            idCompu = IDCOMPU;
            deviceID = DEVICEID;
            idEdificio = IDEdificio;
            nUsuarioAlta = NUSUARIOA;
            nUsuarioTecnico = NUSUARIOT;
            idDispositivo = IDDISPOSITIVO;
        }

        public int pincidente
        {
            get
            {
                return nIncidnete;
            }
            set
            {
                nIncidnete = value;
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
        public int pesCompu
        {
            get
            {
                return esCompu;
            }
            set
            {
                esCompu = value;
            }
        }
        public int pesDispositivoRed
        {
            get
            {
                return esDispositivoRed;
            }
            set
            {
                esDispositivoRed = value;
            }
        }
        public int pesOtroDispositivo
        {
            get
            {
                return esOtroDispositivo;
            }
            set
            {
                esOtroDispositivo = value;
            }
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
        public string pidEdificio
        {
            get
            {
                return idEdificio;
            }
            set
            {
                idEdificio = value;
            }
        }
        public string pnUsuarioAlta
        {
            get
            {
                return nUsuarioAlta;
            }
            set
            {
                nUsuarioAlta = value;
            }
        }
        public string pnUsuarioTecnico
        {
            get
            {
                return nUsuarioTecnico;
            }
            set
            {
                nUsuarioTecnico = value;
            }
        }
        public string pidDispositivo
        {
            get
            {
                return idDispositivo;
            }
            set
            {
                idDispositivo = value;
            }
        }
    }
}
