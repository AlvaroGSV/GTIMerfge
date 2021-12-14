using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    class ListTecnicoxservice
    {

        private List<tecnicoxservice> tecnico = new List<tecnicoxservice>();

        public ListTecnicoxservice()
        {
            tecnico = new List<tecnicoxservice>();
        }

        public void agregarTxS(string Idservice, string idtecnico)
        {
            tecnico.Add(new tecnicoxservice(Idservice, idtecnico));
        }

        public string[] ImprimirTxS()
        {
            string[] arreglo = new string[tecnico.Count];
            int pos = 0;
            foreach (tecnicoxservice item in tecnico)
            {
                arreglo[pos] = item.pidservice;
                pos++;
            }
            return arreglo;
        }

    }
}
