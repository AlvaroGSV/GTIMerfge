using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    internal class ListComputerComponentList
    {
        private List<computerComponentList> componentLists = new List<computerComponentList>();
        public int AgregarAula(computerComponentList componentList)
        {
            int exito = 0;
            //exito = maneja.RegistraPlatillo(platillo.pDescripcion, platillo.pImprte, platillo.pTiempo);
            return exito;
        }
        public List<computerComponentList> GetAulas()
        {
            return componentLists;//Solo para no tener errores
            //List<string> menu = maneja.PlatilloGenerales();
            //return menu;
        }
    }
}
