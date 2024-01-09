using Commant_Domin.CommentAgg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commant_infarstucter_EFCore
{
    public class CoomentContext:DbContext
    {
        public DbSet<Commant> Commants { get; set; }
        public CoomentContext(DbContextOptions<CoomentContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var asmbaly = typeof(CoomentContext).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(asmbaly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
