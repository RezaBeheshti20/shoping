using Domin_invantorii.InvantoriyAgg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_invantori.Infarastucher.EFcor.Mapping
{
    public class invantoriiMapping : IEntityTypeConfiguration<Invantoriyy>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Invantoriyy> builder)
        {
            builder.ToTable("INvantoriyy");
            builder.HasKey(x => x.Id);

            builder.OwnsMany(x => x.Oprations, ModelBuilder =>
            {
                ModelBuilder.HasKey(x => x.Id);
                ModelBuilder.ToTable("Oprations");
                ModelBuilder.Property(x=>x.Description).HasMaxLength(1000);
                ModelBuilder.WithOwner(x => x.Invantoriy).HasForeignKey(x => x.Id);

            });
        }
    }
}
