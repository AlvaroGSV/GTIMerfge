using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class ListComputer
    {
        private List<computer> computers = new List<computer>();

        public ListComputer()
        {
            computers = new List<computer>();
        }
        public void Agregarcomputer(string IDCOMPU, string AULANUM, string NUMINCI, string SOFTESP, string IDHARD, string IDSOFT, string ADDMAC, string EDIFICIO, string RAZONUSO)
        {
            computers.Add(new computer(IDCOMPU, AULANUM, NUMINCI, SOFTESP, IDHARD, IDSOFT, ADDMAC, EDIFICIO, RAZONUSO));
        }
        public List<computer> GetAulas()
        {
            return computers;//Solo para no tener errores
            //List<string> menu = maneja.PlatilloGenerales();
            //return menu;
        }

        public string[] Imprimircomputer()
        {
            string[] arreglo = new string[computers.Count];
            int pos = 0;
            foreach (computer item in computers)
            {
                arreglo[pos] = item.pidCompu;
                pos++;
            }
            return arreglo;
        }
    }
}
