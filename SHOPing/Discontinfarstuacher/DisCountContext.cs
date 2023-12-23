using DicuntM_Domin.Colleague;
using DicuntM_Domin.CustomerAgg;
using Discontinfarstuacher.Mapping;
using Microsoft.EntityFrameworkCore;
using System;

namespace Discontinfarstuacher
{
    public class DisCountContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Colleague> Colleagues { get; set; }
        public DisCountContext(DbContextOptions<DisCountContext> options):base(options) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var Asmbeli=typeof(CustomerMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(Asmbeli);

            base.OnModelCreating(modelBuilder);
        }
    }
}
