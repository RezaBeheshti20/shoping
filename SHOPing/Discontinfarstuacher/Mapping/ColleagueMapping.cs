using DicuntM_Domin.Colleague;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discontinfarstuacher.Mapping
{
    public class ColleagueMapping : IEntityTypeConfiguration<Colleague>
    {
        public void Configure(EntityTypeBuilder<Colleague> builder)
        {
            builder.ToTable("Colleague");
            builder.HasKey(x => x.Id);
        }
    }
}
