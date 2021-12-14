using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    class tecnicoxservice
    {

        string idservice, IDtecnico;

        public tecnicoxservice(string Idservice, string idtecnico)
        {
            idservice = Idservice;
            IDtecnico = idtecnico;
        }

        public string pidservice
        {
            get
            {
                return idservice;
            }
            set
            {
                idservice = value;
            }
        }
        public string pIDtecnico
        {
            get
            {
                return IDtecnico;
            }
            set
            {
                IDtecnico = value;
            }
        }
       
    }
}
