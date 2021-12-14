using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class ListIncidentesXtecnico
    {
        private List<incidentesXtecnico> incidentes = new List<incidentesXtecnico>();
        private incidentesXtecnico[] arregloIncxtec = new incidentesXtecnico[99];
        public int Agregar(incidentesXtecnico query)
        {
            int exito = 0;
            //exito = maneja.RegistraPlatillo(platillo.pDescripcion, platillo.pImprte, platillo.pTiempo);
            return exito;
        }
        public List<incidentesXtecnico> GetAll()
        {
            return incidentes;//Solo para no tener errores
            //List<string> menu = maneja.PlatilloGenerales();
            //return menu;
        }

        public string[] ImprimeIncidente()
        {
            string[] arreglo = new string[arregloIncxtec.Length];
            int pos = 0;
            foreach (incidentesXtecnico item in arregloIncxtec)
            {
                if (item != null)
                {
                    arreglo[pos] = item.pnUsuario;
                    pos++;
                }
            }
            return arreglo;
        }
    }
}
