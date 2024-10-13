using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreLayer
{
    public class Post
    {
        int id;
        string contenu;
        DateTime date;
        Utilisateur? utilisateur;
        public int Id { get => id; set => id = value; }
        public string Contenu { get => contenu; set => contenu = value; }
        public DateTime Date { get => date; set => date = value; }
        public Utilisateur? Utilisateur { get => utilisateur; set => utilisateur = value; }
    }
}
