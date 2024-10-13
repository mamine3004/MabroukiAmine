using coreLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoLayer.Utilisateurs
{
    public class UtilisateurService : IUtilisateur
    {
        private PostContext _context;

        public UtilisateurService(PostContext context)
        {
            _context = context;
        }

        public int addPost(int idu, Post post)
        {
            Utilisateur? user = _context.utilisateurs.FirstOrDefault(u => u.Id == idu);
            if (user == null)
            {
                return 0;

            }
            post.Utilisateur = user;
            _context.posts.Add(post);
            int nb = _context.SaveChanges();
            return nb;
        }

        public Utilisateur? authentification(string login, string password)
        {
            Utilisateur? user = _context.utilisateurs.FirstOrDefault(u => u.Log == login && u.Pass == password);
            return user;
        }

        public int inscription(Utilisateur user)
        {
            _context.utilisateurs.Add(user);
            int nb = _context.SaveChanges();
            return nb;
        }
    }
}
