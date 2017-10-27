using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusTickets.BusinessServices.Interfices;
using BusTickets.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace BusTickets.BusinessServices.Services
{
    public class CityNearbyService : BaseService, ICityNearbyService
    {
        public CityNearbyService(IBusTicketDbContext contetx)
            : base(contetx)
        {
        }

        public async Task<IList<CitiesNearby>> GetCitiseNearbyAsync(int cityId)
        {
            return await this.Context.CitiesNearbys
                .AsNoTracking()
                .Where(s => s.CityID == cityId)
                .ToListAsync();
        }
    }
}
