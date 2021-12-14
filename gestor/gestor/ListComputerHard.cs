using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    internal class ListComputerHard
    {
        private List<ComputerHard> computerHards = new List<ComputerHard>();
        public ListComputerHard()
        {
            computerHards = new List<ComputerHard>();
        }
        public void AgregarHard(string IDHARD, string SALIDAV, string SALIDAA, string PROCESADOR, string VENTILADOR, string famprocesador, string TarjetaMadre)
        {
            computerHards.Add(new ComputerHard(IDHARD, SALIDAV, SALIDAA, PROCESADOR, VENTILADOR, famprocesador, TarjetaMadre));
        }
        public List<ComputerHard> GetAulas()
        {
            return computerHards;//Solo para no tener errores
            //List<string> menu = maneja.PlatilloGenerales();
            //return menu;
        }

        public string[] ImprimirPasos()
        {
            string[] arreglo = new string[computerHards.Count];
            int pos = 0;
            foreach (ComputerHard item in computerHards)
            {
                arreglo[pos] = item.pidHar;
                pos++;
            }
            return arreglo;
        }
    }
}
