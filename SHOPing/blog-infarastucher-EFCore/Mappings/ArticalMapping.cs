using Domin_Blog_M.ArticalAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog_infarastucher_EFCore.Mappings
{
    public class ArticalMapping : IEntityTypeConfiguration<Artical>
    {
        public void Configure(EntityTypeBuilder<Artical> builder)
        {
            builder.ToTable("Artica REZA");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Titel).HasMaxLength(500);
            builder.Property(x => x.Picture).HasMaxLength(500);
            builder.Property(x => x.PictureAlt).HasMaxLength(500);
            builder.Property(x => x.PictureTiTle).HasMaxLength(500);
            builder.Property(x => x. ShortDescription).HasMaxLength(250);
            builder.Property(x => x.Kewords).HasMaxLength(500);
            builder.Property(x => x.Slug).HasMaxLength(500);
            builder.Property(x => x.MetaDescription).HasMaxLength(500);
            builder.Property(x => x.CanonicalAddras).HasMaxLength(500);

            builder.HasOne(X => X.Catagoriy).WithMany(x => x.Articals).HasForeignKey(x => x.CategoryId);

        }
    }
}
