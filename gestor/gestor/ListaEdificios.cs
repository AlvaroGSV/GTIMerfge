using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class ListaEdificios
    {
        private List<edificio> edificios = new List<edificio>();
        public void AgregarEdificio(edificio edifici)
        {
            edificios.Add(edifici);
        }
        public List<edificio> GetAll()
        {
            return edificios;
        }
    }
}
