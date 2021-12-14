using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    internal class ListLicencias
    {
        private List<licencia> licencias = new List<licencia>();
        public int AgregarAula(licencia licencia)
        {
            int exito = 0;
            //exito = maneja.RegistraPlatillo(platillo.pDescripcion, platillo.pImprte, platillo.pTiempo);
            return exito;
        }
        public List<licencia> GetAulas()
        {
            return licencias;//Solo para no tener errores
            //List<string> menu = maneja.PlatilloGenerales();
            //return menu;
        }
    }
}
