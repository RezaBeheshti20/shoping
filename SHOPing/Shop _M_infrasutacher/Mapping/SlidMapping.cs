using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SHop__m_Domin.SlidAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop__M_infrasutacher.Mapping
{
    public class SlidMapping : IEntityTypeConfiguration<Slid>
    {
        public void Configure(EntityTypeBuilder<Slid> builder)
        {
            builder.ToTable("Slid");
            builder.HasKey(x => x.Id);


            builder.Property(x=>x.Pictur).HasMaxLength(100).IsRequired();
            builder.Property(x => x.PicturAlt).HasMaxLength(500).IsRequired();
            builder.Property(x => x.PicturTitel).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Text).HasMaxLength(255);
            builder.Property(x => x.Titel).HasMaxLength(255);
            builder.Property(x => x.Heding).HasMaxLength(255).IsRequired();
            builder.Property(x => x.BtnText).HasMaxLength(50).IsRequired();
        }
    }
}
