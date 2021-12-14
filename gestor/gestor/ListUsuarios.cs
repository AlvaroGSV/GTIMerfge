using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class ListUsuarios
    {
        private List<usuarios> user = new List<usuarios>();
        public void Agregar(usuarios usuario)
        {
            user.Add(usuario);
        }
        public List<usuarios> GetAll()
        {
            return user;
        }
        public int LogIn(string nUsuario, string passkey)
        {
            int tUser = 5;
            for(int i = 0; i < user.Count; i++)
            {
                if(user[i].pnUsuario == nUsuario && user[i].ppasskey == passkey)
                {
                    tUser = user[i].ptipoUsuario;
                }
            }
            return tUser;
        }
    }
}
