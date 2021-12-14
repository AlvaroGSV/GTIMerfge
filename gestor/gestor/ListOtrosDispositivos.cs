using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    internal class ListOtrosDispositivos
    {
        private List<otrosDispositivos> otroDispositivo = new List<otrosDispositivos>();
        public int Agregar(otrosDispositivos dispositivo)
        {
            int exito = 0;
            //exito = maneja.RegistraPlatillo(platillo.pDescripcion, platillo.pImprte, platillo.pTiempo);
            return exito;
        }
        public List<otrosDispositivos> GetAll()
        {
            return otroDispositivo;//Solo para no tener errores
            //List<string> menu = maneja.PlatilloGenerales();
            //return menu;
        }
    }
}
