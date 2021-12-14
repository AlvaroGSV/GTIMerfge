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
        public int AgregarDocumentacion(documentacion documentacion)
        {
            int exito = 0;
            //exito = maneja.RegistraPlatillo(platillo.pDescripcion, platillo.pImprte, platillo.pTiempo);
            return exito;
        }
        public List<documentacion> GetAulas()
        {
            return documentacion;//Solo para no tener errores
            //List<string> menu = maneja.PlatilloGenerales();
            //return menu;
        }
    }
}
