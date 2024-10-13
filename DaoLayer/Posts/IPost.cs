using coreLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoLayer.Posts
{
    public interface IPost
    {
        public int addPost(int idu, Post post);
        public List<Post>? getAllPosts();
        public List<Post>? getAllPostsByUser(int idu);
    }
}
