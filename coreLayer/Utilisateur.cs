using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreLayer
{
    public class Utilisateur
    {
        int id;
        string log;
        string pass;
        List<Post>? posts = new List<Post> ();

        public int Id { get => id; set => id = value; }
        public string Log { get => log; set => log = value; }
        public string Pass { get => pass; set => pass = value; }
        public List<Post>? Posts { get => posts; set => posts = value; }
    }
}
