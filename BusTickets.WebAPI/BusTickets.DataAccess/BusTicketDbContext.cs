using Microsoft.EntityFrameworkCore;

namespace BusTickets.DataAccess
{
    public class BusTicketDbContext : DbContext, IBusTicketDbContext
    {
        public virtual DbSet<Ticket> CitiesNearbys { get; set; }

        public virtual DbSet<City> Cities { get; set; }

        public virtual DbSet<BusStop> BusStops { get; set; }

        public virtual DbSet<BusStation> BusStations { get; set; }

        public virtual DbSet<Journey> Journeys { get; set; }

        public virtual DbSet<Driver> Drivers { get; set; }

        public virtual DbSet<Review> Reviews { get; set; }

        public virtual DbSet<Bus> Buses { get; set; }

        public virtual DbSet<BusType> BusTypes { get; set; }

        public virtual DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = @"Server=.;Database=BusTicket;Trusted_Connection=True;";
            var retryLogicCount = 3;

            optionsBuilder.UseSqlServer(connection, opton => opton.EnableRetryOnFailure(retryLogicCount));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CitiesNearby>().HasOne(s => s.CityNearby)
            .WithMany(s => s.CitiesNearby)
            .HasForeignKey(s => s.CityNearbyID)
            .HasConstraintName("CityNearbyID_fk")
            .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<CitiesNearby>().HasOne(s => s.City)
            .WithMany(s => s.Cities)
            .HasForeignKey(s => s.CityID)
            .HasConstraintName("CityID_fk")
            .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Journey>().HasOne(s => s.DepartureBusStation)
             .WithMany(s => s.DepartureBusStation)
             .HasForeignKey(s => s.DepartureStationID)
             .HasConstraintName("DepartureID_fk")
             .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Journey>().HasOne(s => s.ArrivalBusStation)
              .WithMany(s => s.ArrivalBusStation)
              .HasForeignKey(s => s.ArrivalStationID)
              .HasConstraintName("ArrivalID_fk")
              .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Ticket>().HasOne(s => s.CityFrom)
                .WithMany(s => s.CityFrom)
                .HasForeignKey(s => s.CityFromID)
                .HasConstraintName("CityFromID_fk")
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Ticket>().HasOne(s => s.CityTo)
                .WithMany(s => s.CityTo)
                .HasForeignKey(s => s.CityToID)
                .HasConstraintName("CityToID_fk")
                .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(modelBuilder);
        }
    }
}
