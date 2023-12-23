using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SHop__m_Domin.ProductPicturAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop__M_infrasutacher.Mapping
{
    public class ProductPicturMapping : IEntityTypeConfiguration<ProductPictur>
    {
        public void Configure(EntityTypeBuilder<ProductPictur> builder)
        {
            builder.ToTable("ProductPictur");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Pictur).HasMaxLength(100).IsRequired();
            builder.Property(x => x.PicturTitel).HasMaxLength(100).IsRequired();
            builder.Property(x => x.PicturAlt).HasMaxLength(100).IsRequired();

            builder.HasOne(x => x.Product).WithMany(x => x.ProductPicturs).HasForeignKey(x => x.ProductId);

        }
    }
}
