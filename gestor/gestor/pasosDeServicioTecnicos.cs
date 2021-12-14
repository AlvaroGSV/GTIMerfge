using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class pasosDeServicioTecnicos
    {
        int  nPaso;
        string IdServicio, descPaso;

        public pasosDeServicioTecnicos(string IDservicio, int Npaso, string Descpaso)
        {
            IdServicio = IDservicio;
            nPaso = Npaso;
            descPaso = Descpaso;
        }

        public string pIdServicio
        {
            get
            {
                return IdServicio;
            }
            set
            {
                IdServicio = value;
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
