using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class ListPasosDeServicioTecnicos
    {
        private List<pasosDeServicioTecnicos> steps = new List<pasosDeServicioTecnicos>();

        public ListPasosDeServicioTecnicos()
        {
            steps = new List<pasosDeServicioTecnicos>();
        }

        public void Agregar(string IDservicio, int Npaso, string Descpaso)
        {
            steps.Add(new pasosDeServicioTecnicos(IDservicio, Npaso, Descpaso));
        }
        public List<pasosDeServicioTecnicos> GetAll()
        {
            return steps;//Solo para no tener errores
            //List<string> menu = maneja.PlatilloGenerales();
            //return menu;
        }

        public string[] ImprimirPasos()
        {
            string[] arreglo = new string[steps.Count];
            int pos = 0;
            foreach (pasosDeServicioTecnicos item in steps)
            {
                arreglo[pos] = item.pIdServicio;
                pos++;
            }
            return arreglo;
        }
    }
}
