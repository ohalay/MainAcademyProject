using BusTickets.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace BusTickets.DataAccess
{
    public class BusTicketDbContext : DbContext, IBusTicketDbContext
    {
        public virtual DbSet<CitiesNearby> CitiesNearbys { get; set; }

        public virtual DbSet<City> Cities { get; set; }

        public virtual DbSet<BusStop> BusStops { get; set; }

        public virtual DbSet<BusStation> BusStations { get; set; }

        public virtual DbSet<Journey> Journeys { get; set; }

        public virtual DbSet<Driver> Drivers { get; set; } ////S

        public virtual DbSet<Review> Reviews { get; set; } ////S

        public virtual DbSet<Bus> Buses { get; set; } ////C

        public virtual DbSet<BusType> BusTypes { get; set; } ////C

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = @"Server=.;Database=BusTicket;Trusted_Connection=True;";
            var retryLogicCount = 3;

            optionsBuilder.UseSqlServer(connection, opton => opton.EnableRetryOnFailure(retryLogicCount));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Journey>().HasOne(s => s.DepartureBusStation)
                .WithMany(s => s.DepartureBusStation)
                .HasForeignKey(s => s.DepartureStationID)
                .HasConstraintName("DepartureBusStation_fk")
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Journey>().HasOne(s => s.ArrivalBusStation)
                .WithMany(s => s.ArrivalBusStation)
                .HasForeignKey(s => s.ArrivalStationID)
                .HasConstraintName("ArrivalBusStation_fk")
                .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(modelBuilder);
        }
    }
}
