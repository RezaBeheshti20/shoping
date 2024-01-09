using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SHop__m_Domin.ProductAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop__M_infrasutacher.Mapping
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);



            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Code).HasMaxLength(50).IsRequired();
            builder.Property(x => x.ShortDescription).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Picture).HasMaxLength(50).IsRequired();
            builder.Property(x => x.PictureAlt).HasMaxLength(50).IsRequired();
            builder.Property(x => x.PicturTitle).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Keywords).HasMaxLength(50).IsRequired();
            builder.Property(x => x.MetaDescription).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Slug).HasMaxLength(50).IsRequired();

            builder.HasOne(x => x.Category).WithMany(x => x.products).HasForeignKey(x => x.CategoreyId);

            builder.HasMany(x => x.ProductPicturs).WithOne(x => x.Product).HasForeignKey(x => x.ProductId);
        }
    }
}
