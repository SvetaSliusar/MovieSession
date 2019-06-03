using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSession.Dal.EntityConfigs
{
    public class GenreConfiguration :
        IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.Property(genre => genre.Name)
                .HasColumnType("varchar(20)");
        }
    }
}
