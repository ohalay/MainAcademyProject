using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task<IList<City>> GetCityAsync(string starwithcity)
        {
            {
                return await this.Context.Cities
                    .AsNoTracking()
                    .Where(c => c.Name.StartsWith(starwithcity))
                    .ToListAsync();
            }
        }
    }
}
