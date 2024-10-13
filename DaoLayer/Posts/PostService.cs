using coreLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoLayer.Posts
{
    public class PostService : IPost
    {
        private PostContext _context;

        public PostService(PostContext context)
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


        public List<Post>? getAllPosts()
        {
            List<Post>? posts = _context.posts.Include(p => p.Utilisateur).ToList();
            return posts;

        }

        public List<Post>? getAllPostsByUser(int idu)
        {
            Utilisateur? user = _context.utilisateurs.Include(u => u.Posts).FirstOrDefault(u => u.Id == idu);
            if (user == null) { return []; }
            return user.Posts;
        }
    }
}
