using Microsoft.EntityFrameworkCore;

namespace BusTickets.DataAccess
{
    public interface IBusTicketDbContext
    {
         DbSet<CitiesNearby> CitiesNearbys { get; set; }

         DbSet<City> Cities { get; set; }

         DbSet<BusStop> BusStops { get; set; }

         DbSet<BusStation> BusStations { get; set; }

         DbSet<Journey> Journeys { get; set; }

         DbSet<Driver> Drivers { get; set; }

         DbSet<Review> Reviews { get; set; }

         DbSet<Bus> Buses { get; set; }

         DbSet<BusType> BusTypes { get; set; }

        DbSet<Ticket> Tickets { get; set; }
    }
}