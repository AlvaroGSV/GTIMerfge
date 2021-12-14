using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class serviciosTecnicos
    {
        string nServicio, tiempoEstimado, nomServicio, descServicio;

        public serviciosTecnicos(string serviocioNum, string tiempoE, string ServicioName, string serviciodesc)
        {
            nServicio = serviocioNum;
            tiempoEstimado = tiempoE;
            nomServicio = ServicioName;
            descServicio = serviciodesc;
        }

        public string pnservicio
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

        public string ptiempoestimado
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
