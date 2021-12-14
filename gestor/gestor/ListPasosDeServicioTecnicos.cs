using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    internal class ListPasosDeServicioTecnicos
    {
        private List<pasosDeServicioTecnicos> steps = new List<pasosDeServicioTecnicos>();
        public int Agregar(pasosDeServicioTecnicos step)
        {
            int exito = 0;
            //exito = maneja.RegistraPlatillo(platillo.pDescripcion, platillo.pImprte, platillo.pTiempo);
            return exito;
        }
        public List<pasosDeServicioTecnicos> GetAll()
        {
            return steps;//Solo para no tener errores
            //List<string> menu = maneja.PlatilloGenerales();
            //return menu;
        }
    }
}
