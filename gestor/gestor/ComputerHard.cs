using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class ComputerHard
    {
        string salidaVideo, salidaAudio, procesador, ventilador, idHard, familiaProcesador, tarjetamadre;

        public ComputerHard(string IDHARD, string SALIDAV, string SALIDAA, string PROCESADOR, string VENTILADOR, string famprocesador, string TarjetaMadre)
        {
            idHard = IDHARD;
            salidaVideo = SALIDAV;
            salidaAudio = SALIDAA;
            procesador = PROCESADOR;
            ventilador = VENTILADOR;
            familiaProcesador = famprocesador;
            tarjetamadre = TarjetaMadre;
        }

        public string pidHar
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

        public string psalidaVideo
        {
            get
            {
                return salidaVideo;
            }
            set
            {
                salidaVideo = value;
            }
        }

        public string psalidaAudio
        {
            get
            {
                return salidaAudio;
            }
            set
            {
                salidaAudio = value;
            }
        }

        public string pprocesador
        {
            get
            {
                return procesador;
            }
            set
            {
                procesador = value;
            }
        }

        public string pventilador
        {
            get
            {
                return ventilador;
            }
            set
            {
                ventilador = value;
            }
        }

        public string pfamiliaProcesador
        {
            get
            {
                return familiaProcesador;
            }
            set
            {
                familiaProcesador = value;
            }
        }

        public string ptarjetamadre
        {
            get
            {
                return tarjetamadre;
            }
            set
            {
                tarjetamadre = value;
            }
        }
    }
}
