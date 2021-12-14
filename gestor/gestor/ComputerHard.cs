using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class ComputerHard
    {
        int idHard, salidaVideo, salidaAudio, procesador, ventilador;
        string familiaProcesador, tarjetamadre;

        ComputerHard(int IDHARD, int SALIDAV, int SALIDAA, int PROCESADOR, int VENTILADOR, string famprocesador, string TarjetaMadre)
        {
            idHard = IDHARD;
            salidaVideo = SALIDAV;
            salidaAudio = SALIDAA;
            procesador = PROCESADOR;
            ventilador = VENTILADOR;
            familiaProcesador = famprocesador;
            tarjetamadre = TarjetaMadre;
        }

        public int pidHar
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

        public int psalidaVideo
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

        public int psalidaAudio
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

        public int pprocesador
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

        public int pventilador
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
