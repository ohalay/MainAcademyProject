using System.Collections.Generic;
using System.Linq;
using BusTickets.BusinessServices.Interfices;
using BusTickets.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace BusTickets.BusinessServices.Services
{
    public class CityService : BaseService, ICityService
    {
        public CityService(IBusTicketDbContext context)
            : base(context)
        {
        }

        public IList<City> GetCity(string starwithcity)
        {
            {
                return this.Context.Cities
                    .AsNoTracking()
                    .Where(c => c.Name.StartsWith(starwithcity))
                    .ToList();
            }
        }
    }
}
