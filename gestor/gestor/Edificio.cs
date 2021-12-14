using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class edificio
    {
        string IdEdificio;
        string text;

        edificio(string ID, string Text)
        {
            IdEdificio = ID;
            text = Text;
        }

        public string idEdificio
        {
            get
            {
                return IdEdificio;
            }
            set
            {
                IdEdificio = value;
            }
        }

        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
            }
        }
    }
}
