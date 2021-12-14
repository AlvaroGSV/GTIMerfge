using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    internal class ListUsuarios
    {
        private List<usuarios> user = new List<usuarios>();
        public int Agregar(usuarios usuario)
        {
            int exito = 0;
            //exito = maneja.RegistraPlatillo(platillo.pDescripcion, platillo.pImprte, platillo.pTiempo);
            return exito;
        }
        public List<usuarios> GetAll()
        {
            return user;//Solo para no tener errores
            //List<string> menu = maneja.PlatilloGenerales();
            //return menu;
        }
        public int LogIn()
        {
            return 0;
        }
    }
}
