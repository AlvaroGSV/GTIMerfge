using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class Tecnicos
    {
        int numIncidentesActuales, numIncidentesResueltos, experienceLvl;
        string nUsuario;

        Tecnicos(int numInciA, int numInciR, int expLVl, string Nusuario)
        {
            numIncidentesActuales = numInciA;
            numIncidentesResueltos = numInciR;
            experienceLvl = expLVl;
            nUsuario = Nusuario;
        }

        public int pnumIncidentesActuales
        {
            get
            {
                return numIncidentesActuales;
            }
            set
            {
                numIncidentesActuales = value;
            }
        }

        public int pnumIncidentesResueltos
        {
            get
            {
                return numIncidentesResueltos;
            }
            set
            {
                numIncidentesResueltos = value;
            }
        }
        public int pexperienceLvl
        {
            get
            {
                return experienceLvl;
            }
            set
            {
                experienceLvl = value;
            }
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
    }
}
