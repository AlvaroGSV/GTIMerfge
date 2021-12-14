using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    internal class ListSoftConfig
    {
        private List<softConfig> softConfigs = new List<softConfig>();
        public int AgregarAula(softConfig config)
        {
            int exito = 0;
            //exito = maneja.RegistraPlatillo(platillo.pDescripcion, platillo.pImprte, platillo.pTiempo);
            return exito;
        }
        public List<softConfig> GetAulas()
        {
            return softConfigs;//Solo para no tener errores
            //List<string> menu = maneja.PlatilloGenerales();
            //return menu;
        }
    }
}
