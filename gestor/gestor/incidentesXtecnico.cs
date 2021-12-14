using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class incidentesXtecnico
    {
        string nUsuario;
        int nIncidnete, prioridad;

        incidentesXtecnico(string NUSUARIO, int Nincidente, int Prioridad)
        {
            nUsuario = NUSUARIO;
            nIncidnete = Nincidente;
            prioridad = Prioridad;
        }

        public string pnUsuario
        {
            get
            {
                return nUsuario;
            }
            set
            {
                nUsuario = value;
            }
        }

        public int pnIncidente
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

        public int pprioridad
        {
            get
            {
                return prioridad;
            }
            set
            {
                prioridad = value;
            }
        }
    }
}
