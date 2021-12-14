using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class ListComputerSoft
    {
        private List<computerSoft> soft = new List<computerSoft>();
        public void Agregar(computerSoft computerSoft)
        {
            soft.Add(computerSoft);
        }
        public List<computerSoft> GetAll()
        {
            return soft;
        }
        public int getLastId()
        {
            int res = 0;
            res = soft.Count;
            return res;
        }
    }
}
