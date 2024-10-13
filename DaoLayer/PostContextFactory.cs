using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoLayer
{
    public class PostContextFactory : IDesignTimeDbContextFactory<PostContext>
    {
        public PostContext CreateDbContext(string[] args)
        {
            var optionsDbContext = new DbContextOptionsBuilder<PostContext>();
            optionsDbContext.UseSqlServer("Data Source=DESKTOP-TOLSAEC\\SQLEXPRESS;Initial Catalog=postmanager;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            return new PostContext(optionsDbContext.Options);
        }
    }
}
