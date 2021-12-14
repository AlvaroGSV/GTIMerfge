using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    internal class ListCategoriaInventario
    {
        private List<CategoryInvetario> categoryInvetarios = new List<CategoryInvetario>();
        public int Agregar(CategoryInvetario category)
        {
            int exito = 0;
            //exito = maneja.RegistraPlatillo(platillo.pDescripcion, platillo.pImprte, platillo.pTiempo);
            return exito;
        }
        public List<CategoryInvetario> GetAll()
        {
            return categoryInvetarios;//Solo para no tener errores
            //List<string> menu = maneja.PlatilloGenerales();
            //return menu;
        }
    }
}
