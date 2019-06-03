using Microsoft.EntityFrameworkCore;
using MovieSession.Dal.EntityConfigs;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MovieSession.Dal
{
    public class MovieSessionDbContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<TicketOrder> TicketOrders { get; set; }
        public DbSet<CinemaHall> CinemaHalls { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MovieSessionDbContext).Assembly);
        }
    }
}
