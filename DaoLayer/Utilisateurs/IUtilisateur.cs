using coreLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoLayer.Utilisateurs
{
    public interface IUtilisateur
    {
        public Utilisateur? authentification(string login, string password);
        public int inscription(Utilisateur user);

    }
}
