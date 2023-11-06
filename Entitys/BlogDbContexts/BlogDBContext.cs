using Entitys.Models.ControlPanelModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys.BlogDbContexts
{
    public class BlogDBContext : DbContext
    {
        public BlogDBContext(DbContextOptions options):base (options)
        {
        }

        public DbSet<BlogPost> blogPosts { get; set; }
        public DbSet<Tages> tages { get; set; }
    }
}
