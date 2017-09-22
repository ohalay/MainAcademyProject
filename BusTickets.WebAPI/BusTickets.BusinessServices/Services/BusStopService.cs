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

        public IList<BusStop> GetBusStop(int jorneyID)
        {
            return this.Context.BusStops
                .AsNoTracking()
                .Where(s => s.JorneyID == jorneyID)
                .ToList();
        }
    }
}
