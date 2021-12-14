using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class documentacion
    {
        private int idDocumentacion, manual, garantia;
        private string archivoManual, archivoGarantia;

        public documentacion(int ID, int Manual, int Garantia, string Tmanual, string Tgarantia)
        {
            idDocumentacion = ID;
            manual = Manual;
            garantia = Garantia;
            archivoManual = Tmanual;
            archivoGarantia = Tgarantia;
        }

        public int pidDocumentacion
        {
            get
            {
                return idDocumentacion;
            }
            set
            {
                idDocumentacion = value;
            }
        }

        public int pmanual
        {
            get
            {
                return manual;
            }
            set
            {
                manual = value;
            }
        }

        public int pgarantia
        {
            get
            {
                return garantia;
            }
            set
            {
                garantia = value;

            }
        }

        public string parchivoManual
        {
            get
            {
                return archivoManual;
            }
            set
            {
                archivoManual = value;
            }
        }

        public string parchivoGarantia
        {
            get
            {
                return archivoGarantia;
            }
            set
            {
                archivoGarantia = value;
            }
        }

    }

    
}
