using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class ListDocumentacion
    {
        private List<documentacion> documentacion = new List<documentacion>();
        public int AgregarDocumentacion(documentacion docu)
        {
            int exito = 0;
            documentacion.Add(docu);
            return exito;
        }
        public List<documentacion> GetAll()
        {
            return documentacion;
        }
        public bool isEmpty()
        {
            bool op = false;
            if(documentacion.Count < 0)
            {
                op = true;
                return op;
            }
            return op;
        }
        public int getNumDocumentos()
        {
            int res = 0;
            res=documentacion.Count;
            return res;
        }
    }
}
