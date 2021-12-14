using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class ListLicencias
    {
        private List<licencia> licencias = new List<licencia>();
        public void AgregarAula(licencia licencia)
        {
            licencias.Add(licencia);
        }
        public List<licencia> GetAll()
        {
            return licencias;
        }
        public int getLastId()
        {
            int res = 0;
            res = licencias.Count;
            return res;
        }
    }
}
