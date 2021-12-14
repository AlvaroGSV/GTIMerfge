using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    internal class ListServiciosTecncicos
    {
        private List<serviciosTecnicos> LserviciosTecnicos = new List<serviciosTecnicos>();
        public int Agregar(serviciosTecnicos servicio)
        {
            int exito = 0;
            //exito = maneja.RegistraPlatillo(platillo.pDescripcion, platillo.pImprte, platillo.pTiempo);
            return exito;
        }
        public List<serviciosTecnicos> GetAll()
        {
            return LserviciosTecnicos;//Solo para no tener errores
            //List<string> menu = maneja.PlatilloGenerales();
            //return menu;
        }
    }
}
