using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class otrosDispositivos
    {
        int  idDocumentacion, tiempoVida, mantenimientoMinimo, mantenimientoMaximo, ultimoMantenimiento, aulaNum;
        string idDispositivo, nombre, edificio;

        otrosDispositivos(string IDDISP, int IDDOCUMENT, int TIEMPOVIDA, int MINMANTEN, int MAXMANTEN, int LASTMANTEN, int AULANUM, string NOMBRE, string EDIFICIO)
        {
            idDispositivo = IDDISP;
            idDocumentacion = IDDOCUMENT;
            tiempoVida = TIEMPOVIDA;
            mantenimientoMinimo = MINMANTEN;
            mantenimientoMaximo = MAXMANTEN;
            ultimoMantenimiento = LASTMANTEN;
            aulaNum = AULANUM;
            nombre = NOMBRE;
            edificio = EDIFICIO;
        }

        public string pidDispositivo
        {
            get
            {
                return idDispositivo;
            }
            set
            {
                idDispositivo = value;
            }
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
        public int ptiempoVida
        {
            get
            {
                return tiempoVida;
            }
            set
            {
                tiempoVida = value;
            }
        }
        public int pmantenimientoMinimo
        {
            get
            {
                return mantenimientoMinimo;
            }
            set
            {
                mantenimientoMinimo = value;
            }
        }
        public int pmantenimientoMaximo
        {
            get
            {
                return mantenimientoMaximo;
            }
            set
            {
                mantenimientoMaximo = value;
            }
        }
        public int pultimoMantenimiento
        {
            get
            {
                return ultimoMantenimiento;
            }
            set
            {
                ultimoMantenimiento = value;
            }
        }
        public int paulaNum
        {
            get
            {
                return aulaNum;
            }
            set
            {
                aulaNum = value;
            }
        }
        public string pnombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string pedificio
        {
            get
            {
                return edificio;
            }
            set
            {
                edificio = value;
            }
        }

    }
}
