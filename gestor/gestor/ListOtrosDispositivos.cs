using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class ListOtrosDispositivos
    {
        private List<otrosDispositivos> otroDispositivo = new List<otrosDispositivos>();
        public void Agregar(otrosDispositivos dispositivo)
        {
            otroDispositivo.Add(dispositivo);
        }
        public List<otrosDispositivos> GetAll()
        {
            return otroDispositivo;
        }
        public int getLastId()
        {
            int res = 0;
            res = otroDispositivo.Count;
            return res;
        }
    }
}
