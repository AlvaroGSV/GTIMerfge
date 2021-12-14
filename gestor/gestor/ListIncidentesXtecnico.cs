using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    internal class ListIncidentesXtecnico
    {
        private List<incidentesXtecnico> incidentes = new List<incidentesXtecnico>();
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
    }
}
