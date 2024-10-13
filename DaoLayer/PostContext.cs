using coreLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoLayer
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Utilisateur> utilisateurs { get; set; }
        public DbSet<Post> posts { get; set; }
    }
}
