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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = @"Server=.;Database=BusTicket;Trusted_Connection=True;";
            var retryLogicCount = 3;

            optionsBuilder.UseSqlServer(connection, opton => opton.EnableRetryOnFailure(retryLogicCount));
        }
    }
}
