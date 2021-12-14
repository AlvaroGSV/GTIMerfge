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

        public ListServiciosTecncicos()
        {
            LserviciosTecnicos = new List<serviciosTecnicos>();
        }

        public void AgregarST(string serviocioNum, string tiempoE, string ServicioName, string serviciodesc)
        {
            LserviciosTecnicos.Add(new serviciosTecnicos(serviocioNum,tiempoE,ServicioName,serviciodesc));
        }
        public List<serviciosTecnicos> GetAll()
        {
            return LserviciosTecnicos;//Solo para no tener errores
            //List<string> menu = maneja.PlatilloGenerales();
            //return menu;
        }

        public string[] ImprimirPasos()
        {
            string[] arreglo = new string[LserviciosTecnicos.Count];
            int pos = 0;
            foreach (serviciosTecnicos item in LserviciosTecnicos)
            {
                arreglo[pos] = item.pnservicio;
                pos++;
            }
            return arreglo;
        }
    }
}
