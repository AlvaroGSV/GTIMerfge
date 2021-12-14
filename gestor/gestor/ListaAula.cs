using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class ListaAula
    {
        private List<aula> aulas = new List<aula>();
        public int Agregar(aula aula)
        {
            int exito = 0;
            //exito = maneja.RegistraPlatillo(platillo.pDescripcion, platillo.pImprte, platillo.pTiempo);
            return exito;
        }
        public List<aula> GetAll()
        {
            return aulas;//Solo para no tener errores
            //List<string> menu = maneja.PlatilloGenerales();
            //return menu;
        }
        public List<int> GetAulasByEdificio(string idEdificio)
        {  
            List<int> list = new List<int>();
            return list;
            //List<string> menu = maneja.PlatilloGenerales();
            //return menu;
        }

    }
}
