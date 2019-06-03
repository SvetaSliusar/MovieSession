using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSession.Dal.EntityConfigs
{
    public class TicketOrderConfiguration :
        IEntityTypeConfiguration<TicketOrder>
    {
        public void Configure(EntityTypeBuilder<TicketOrder> builder)
        {
            builder.Property(order => order.DeliveryType)
                .HasConversion<string>();
            builder.Property(order => order.Place)
                .HasColumnType("tinyint");
            builder.Property(order => order.Session)
                .HasColumnType("smalldatetime");
        }
    }
}
