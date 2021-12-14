using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class Tecnicos
    {
        string numIncidentesActuales, numIncidentesResueltos, experienceLvl, nUsuario;

        public Tecnicos(string numInciA, string numInciR, string expLVl, string Nusuario)
        {
            numIncidentesActuales = numInciA;
            numIncidentesResueltos = numInciR;
            experienceLvl = expLVl;
            nUsuario = Nusuario;
        }

        public string pnumIncidentesActuales
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

        public string pnumIncidentesResueltos
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
        public string pexperienceLvl
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
