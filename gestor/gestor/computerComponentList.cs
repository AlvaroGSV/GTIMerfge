using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class computerComponentList
    {
        private int idHard, idProduto;

        computerComponentList(int IDHARD, int IDPRODUC) 
        {
            idHard = IDHARD;
            idProduto = IDPRODUC;
        }

        public int pidHARD
        {
            get
            {
                return idHard;
            }
            set
            {
                idHard = value;
            }
        }

        public int pidproducto
        {
            get
            {
                return idProduto;
            }
            set
            {
                idProduto = value;
            }
        }
    }
}
