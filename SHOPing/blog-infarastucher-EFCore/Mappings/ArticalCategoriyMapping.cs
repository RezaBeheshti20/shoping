using Domin_Blog_M.ArticalCategoriyAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace blog_infarastucher_EFCore.Mappings
{
    public class ArticalCategoriyMapping : IEntityTypeConfiguration<ArticalCatagoriy>
    {
        public void Configure(EntityTypeBuilder<ArticalCatagoriy> builder)
        {
            builder.ToTable("ArticalCategoris REZA");
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Name).HasMaxLength(50);
            builder.Property(x => x.Picture).HasMaxLength(50);
            
            builder.Property(x => x.Description).HasMaxLength(50);
            builder.Property(x => x.Keywords).HasMaxLength(50);
            builder.Property(x => x.Slug).HasMaxLength(50);
            builder.Property(x => x.MetaDiscripiton).HasMaxLength(50);
            builder.Property(x => x. CanonicalAddress).HasMaxLength(50);

            builder.HasMany(x => x.Articals).WithOne(x => x.Catagoriy).HasForeignKey(x => x.CategoryId);
      
        }
    }
}
