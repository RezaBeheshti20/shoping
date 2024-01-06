using blog_infarastucher_EFCore.Mappings;
using Domin_Blog_M.ArticalAgg;
using Domin_Blog_M.ArticalCategoriyAgg;
using Microsoft.EntityFrameworkCore;
using System;

namespace blog_infarastucher_EFCore
{
    public class blogContext:DbContext
    {
        public DbSet<ArticalCatagoriy> articalCatagoriys { get; set; }
        public DbSet<Artical> Articals { get; set; }
        public blogContext(DbContextOptions<blogContext> options):base(options) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var asmbaly = typeof(ArticalCategoriyMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(asmbaly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
