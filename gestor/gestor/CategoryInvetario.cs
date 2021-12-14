using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class CategoryInvetario
    {
        int idCI;
        string txtCI;

        CategoryInvetario(int IDCI, string TXTCI)
        {
            idCI = IDCI;
            txtCI = TXTCI;
        }

        public int pidci
        {
            get
            {
                return idCI;
            }
            set
            {
                idCI = value;
            }
        }

        public string ptxtCI
        {
            get
            {
                return txtCI;
            }
            set
            {
                txtCI = value;
            }
        }
    }
}
