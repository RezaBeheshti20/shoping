using Microsoft.EntityFrameworkCore;
using SHop__m_Domin.ProductAgg;
using SHop__m_Domin.ProductCategoryAgg;
using SHop__m_Domin.ProductPicturAgg;
using SHop__m_Domin.SlidAgg;
using Shop__M_infrasutacher.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop__M_infrasutacher
{
    public class ShopContext:DbContext
    {
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPictur> ProductPicturs { get; set; }
        public DbSet<Slid>  Slids { get; set; }
        public ShopContext(DbContextOptions<ShopContext> options):base(options)
        {

            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var asmbly=typeof(ProductCategoryMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(asmbly);
            base.OnModelCreating(modelBuilder);
        }

      
    }
}
