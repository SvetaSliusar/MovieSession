using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MovieSession.Dal.EntityConfigs
{
    public class CinemaHallConfiguration
        : IEntityTypeConfiguration<CinemaHall>
    {
        public void Configure(EntityTypeBuilder<CinemaHall> builder)
        {
            builder.Property(hall => hall.Capacity)
                .HasColumnType("Tinyint");
        }
    }
}
