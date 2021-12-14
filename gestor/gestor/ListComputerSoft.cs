using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    internal class ListComputerSoft
    {
        private List<computerSoft> soft = new List<computerSoft>();
        public int AgregarAula(computerSoft computerSoft)
        {
            int exito = 0;
            //exito = maneja.RegistraPlatillo(platillo.pDescripcion, platillo.pImprte, platillo.pTiempo);
            return exito;
        }
        public List<computerSoft> GetAulas()
        {
            return soft;//Solo para no tener errores
            //List<string> menu = maneja.PlatilloGenerales();
            //return menu;
        }
    }
}
