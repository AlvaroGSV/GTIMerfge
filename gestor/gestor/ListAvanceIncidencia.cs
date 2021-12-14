using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    internal class ListAvanceIncidencia
    {
        private List<avanceIncidencia> avance = new List<avanceIncidencia>();
        public int Agregar(avanceIncidencia pAvanceIncidencia)
        {
            int exito = 0;
            //exito = maneja.RegistraPlatillo(platillo.pDescripcion, platillo.pImprte, platillo.pTiempo);
            return exito;
        }
        public List<avanceIncidencia> GetAll()
        {
            return avance;//Solo para no tener errores
            //List<string> menu = maneja.PlatilloGenerales();
            //return menu;
        }
    }
}
