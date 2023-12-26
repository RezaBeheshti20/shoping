using Domin_invantorii.InvantoriyAgg;
using M_invantori.Infarastucher.EFcor.Mapping;
using Microsoft.EntityFrameworkCore;
using System;

namespace M_invantori.Infarastucher.EFcor
{
    public class invantoriContext:DbContext
    {
        public DbSet<Invantoriyy>Invantoriyys { get; set; }
        public invantoriContext(DbContextOptions<invantoriContext> options):base(options) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var asmbali = typeof(invantoriiMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly (asmbali);
            base.OnModelCreating(modelBuilder);
        }
    }
}
