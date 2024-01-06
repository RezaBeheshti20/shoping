using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SHop__m_Domin.CommentAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop__M_infrasutacher.Mapping
{
    public class CommantMaping : IEntityTypeConfiguration<Commant>
    {
        public void Configure(EntityTypeBuilder<Commant> builder)
        {
            builder.ToTable("Commantes");
            builder.HasKey(c => c.Id);


            builder.Property(c => c.Name).HasMaxLength(128);
            builder.Property(c=>c.Email).HasMaxLength(128);
            builder.Property(c=>c.Mesasseg).HasMaxLength(128);
            builder.HasOne(x=>x.Products).WithMany(x=>x.Commants).HasForeignKey(x=>x.ProductId);
        }
    }
}
