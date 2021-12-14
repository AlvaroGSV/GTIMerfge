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
        public void Agregar(aula aula)
        {
            aulas.Add(aula);
        }
        public List<aula> GetAll()
        {
            return aulas;
        }

    }
}
