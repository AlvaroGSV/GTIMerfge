using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class avanceIncidencia
    {
        int nIncidnete, fecha, hora, servicioXRealizar;
        string diagnosticoInicial;
    
        avanceIncidencia(int NIncidente, int Fecha, int Hora, int SxR, string diaginicial)
        {
            nIncidnete = NIncidente;
            fecha = Fecha;
            hora = Hora;
            servicioXRealizar = SxR;
            diagnosticoInicial = diaginicial;
        }

        public int pnIncident
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

        public int pfecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }

        public int phora
        {
            get
            {
                return hora;
            }
            set
            {
                hora = value;
            }
        }

        public int pservicioXRealizar
        {
            get
            {
                return servicioXRealizar;
            }
            set
            {
                servicioXRealizar = value;
            }
        }

        public string pdiagnosticoInicial
        {
            get
            {
                return diagnosticoInicial;
            }
            set
            {
                diagnosticoInicial = value;
            }
        }
    }
}
