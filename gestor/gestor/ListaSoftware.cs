using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class ListaSoftware
    {
        private List<software> soft = new List<software>();
        public void AgregarSoftware(software software)
        {
            soft.Add(software);
        }
        public List<software> GetSoftware()
        {
            return soft;
        }
        public int getLastId()
        {
            int res = 0;
            res = soft.Count;
            return res;
        }
        public int getByName(string name)
        {
            int id = 0;
            for(int i = 0; i < soft.Count; i++)
            {
                if(soft[i].pnombre.ToString() == name) 
                { 
                    id = soft[i].pidSoftware;
                }
            }
            return id;
        }

        public List<string> getSoftNames() 
        {
            List<string> names = new List<string>();
            for (int i = 0; i < soft.Count; i++) 
            {
                names.Add(soft[i].pnombre.ToString());
            }
            return names;
        }

        public List<string> getBySO(string name)
        {
            List<string> nom = new List<string>();
            for (int i = 0; i < soft.Count; i++)
            {
                if (soft[i].pso.ToString() == name)
                {
                    nom.Add(soft[i].pnombre.ToString());
                }
            }
            return nom;
        }
    }
}
