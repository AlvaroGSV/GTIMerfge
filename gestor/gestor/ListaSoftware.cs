using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class ListaSoftware
    {
        private List<software> soft = new List<software>();
        public int AgregarSoftware(software software)
        {
            int exito = 0;
            //exito = maneja.RegistraPlatillo(platillo.pDescripcion, platillo.pImprte, platillo.pTiempo);
            return exito;
        }
        public List<software> GetSoftware()
        {
            return soft;//Solo para no tener errores
            //List<string> menu = maneja.PlatilloGenerales();
            //return menu;
        }
    }
}
