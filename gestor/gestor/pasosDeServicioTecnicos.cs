using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class pasosDeServicioTecnicos
    {
        int nServicio, nPaso;
        string descPaso;

        pasosDeServicioTecnicos(int Nservicio, int Npaso, string Descpaso)
        {
            nServicio = Nservicio;
            nPaso = Npaso;
            descPaso = Descpaso;
        }

        public int pnServicio
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

        public int pNpaso
        {
            get
            {
                return nPaso;
            }
            set
            {
                nPaso = value;
            }
        }

        public string pdescPaso
        {
            get
            {
                return descPaso;
            }
            set
            {
                descPaso = value;
            }
        }
    }
}
