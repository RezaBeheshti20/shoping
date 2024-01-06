using Blog_Application;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infarstucher.EFCore
{
    public class BlogContext:DbContext
    {
        public DbSet<ArticalCategoriyApplication> ArticalCategoriys { get; set; }
        public BlogContext(DbContextOptions<BlogContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
