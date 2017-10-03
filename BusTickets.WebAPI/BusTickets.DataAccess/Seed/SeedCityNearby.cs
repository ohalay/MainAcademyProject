using System.Linq;
using BusTickets.DataAccess.Models;

namespace BusTickets.DataAccess.Seed
{
    internal class SeedCityNearby : ISeed
    {
        public void Seed(IBusTicketDbContext context)
        {
            var colection = new[]
            {
                new CityNearby { ID = 1, CityID = 2, Distance = 55.3F, Decscription = "123" },
                new CityNearby { ID = 2, CityID = 1, Distance = 30.3F, Decscription = "66" },
                new CityNearby { ID = 3, CityID = 2, Distance = 80.0F, Decscription = "232" },
            };

            colection
                .ToList()
                .ForEach(s => context.CitiesNearby.AddOrUpdate(s));
        }
    }
}
