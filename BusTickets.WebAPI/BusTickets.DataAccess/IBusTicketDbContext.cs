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

       DbSet<Driver> Drivers { get; set; } ////S

       DbSet<Review> Reviews { get; set; } ////S

       DbSet<Bus> Buses { get; set; } ////C

       DbSet<BusType> BusTypes { get; set; } ////C
    }
}