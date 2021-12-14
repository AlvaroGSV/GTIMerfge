using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class aula
    {
        public int aulaNum;
        public string idEdificio;

        public aula(int Id, string Ide)
        {
            aulaNum = Id;
            idEdificio = Ide;
        }

        public int paulaNum
        {
            get
            {
                return aulaNum;
            }
            set
            {
                aulaNum = value;
            }
        }

        public string pidEdificio
        {
            get
            {
                return idEdificio;
            }
            set
            {
                idEdificio = value;
            }
        }
    }
}
