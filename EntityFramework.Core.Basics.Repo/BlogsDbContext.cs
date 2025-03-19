using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Core.Basics.Repo
{
    class BlogsDbContext:DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Post> Blogs { get; set; }
        public DbSet<Post> BlogSettings { get; set; }
        public DbSet<Post> PostTags { get; set; }
    }
}
