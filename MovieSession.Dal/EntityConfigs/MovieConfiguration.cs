using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSession.Dal.EntityConfigs
{
    public class MovieConfiguration :
        IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.Property(movie => movie.Duration)
                .HasColumnType("time");
            builder.Property(movie => movie.Name)
                .HasColumnType("varchar(20)");
            builder.Property(movie => movie.Description)
                .HasColumnType("varchar(30)");
        }
    }
}
