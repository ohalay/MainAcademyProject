using System.Collections.Generic;
using System.Linq;
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

        public IList<BusStop> GetBusStop(int journeyID)
        {
            return this.Context.BusStops
                .AsNoTracking()
                .Where(s => s.JourneyID == journeyID)
                .ToList();
        }
    }
}
