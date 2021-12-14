using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    internal class ListDispositivosRedes
    {
        private List<NetworkDevices> dispositivosRed = new List<NetworkDevices>();
        public int Agregar(NetworkDevices dispositivoRed)
        {
            int exito = 0;
            //exito = maneja.RegistraPlatillo(platillo.pDescripcion, platillo.pImprte, platillo.pTiempo);
            return exito;
        }
        public List<NetworkDevices> GetAll()
        {
            return dispositivosRed;//Solo para no tener errores
            //List<string> menu = maneja.PlatilloGenerales();
            //return menu;
        }
    }
}
