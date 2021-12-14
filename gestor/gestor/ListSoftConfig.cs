using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class ListSoftConfig
    {
        private List<softConfig> softConfigs = new List<softConfig>();
        public void Agregar(softConfig config)
        {
            softConfigs.Add(config);
        }
        public List<softConfig> GetAll()
        {
            return softConfigs;
        }
        public int getLastId()
        {
            int res = 0;
            res = softConfigs.Count;
            return res;
        }
        public List<string> getSoftNames()
        {
            List<string> names = new List<string>();
            for (int i = 0; i < softConfigs.Count; i++)
            {
                names.Add(softConfigs[i].pNomConfig.ToString());
            }
            return names;
        }
        public int getByName(string name)
        {
            int id = 0;
            for (int i = 0; i < softConfigs.Count; i++)
            {
                if (softConfigs[i].pNomConfig.ToString() == name)
                {
                    id = softConfigs[i].pidSoftware;
                }
            }
            return id;
        }
    }
}
