using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheBlogs.Entities;

namespace TheBlogs.Data
{
    public class TheBlogsContext : DbContext
    {
        public TheBlogsContext (DbContextOptions<TheBlogsContext> options)
            : base(options)
        {
        }

        public DbSet<TheBlogs.Entities.Blog> Blog { get; set; } = default!;
        public DbSet<TheBlogs.Entities.Comment> Comment { get; set; } = default!;
    }
}
