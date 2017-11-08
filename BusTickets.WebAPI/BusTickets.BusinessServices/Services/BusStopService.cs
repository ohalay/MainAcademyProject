using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusTickets.BusinessServices.Interfices;
using BusTickets.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace BusTickets.BusinessServices.Services
{
    public class BusStopService : BaseService, IBusStopService
    {
        public BusStopService(IBusTicketDbContext contetx)
            : base(contetx)
        {
        }

        public async Task<IList<BusStop>> GetBusStopAsync(int journeyID)
        {
            return await this.Context.BusStops
                .AsNoTracking()
                .Where(s => s.JourneyID == journeyID)
                .ToListAsync();
        }
    }
}
