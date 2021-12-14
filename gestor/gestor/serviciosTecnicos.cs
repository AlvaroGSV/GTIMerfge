using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class serviciosTecnicos
    {
        int nServicio, tiempoEstimado;
        string nomServicio, descServicio;

        serviciosTecnicos(int serviocioNum, int tiempoE, string ServicioName, string serviciodesc)
        {
            nServicio = serviocioNum;
            tiempoEstimado = tiempoE;
            nomServicio = ServicioName;
            descServicio = serviciodesc;
        }

        public int pnservicio
        {
            get
            {
                return nServicio;
            }
            set
            {
                nServicio = value;
            }
        }

        public int ptiempoestimado
        {
            get
            {
                return tiempoEstimado;
            }
            set
            {
                tiempoEstimado = value;
            }
        }

        public string pnomservice
        {
            get
            {
                return nomServicio;
            }
            set
            {
                nomServicio = value;
            }
        }

        public string pdescservicio
        {
            get
            {
                return descServicio;
            }
            set
            {
                descServicio = value;
            }
        }
    }
}
