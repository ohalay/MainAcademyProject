namespace BusTickets.BusinessServices.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using BusTickets.BusinessServices.Interfices;
    using BusTickets.DataAccess;
    using Microsoft.EntityFrameworkCore;

    public class TripService : BaseService, ITripService
    {
        public TripService(IBusTicketDbContext contetx)
            : base(contetx)
        {
        }

        public async Task<List<Journey>> GetJourneyByDate(DateTime dateFrom, DateTime dateTo)
        {
            return await this.Context.Journeys
                    .AsNoTracking()
                    .Where(s => s.DepartureTime >= dateFrom && s.DepartureTime <= dateTo)
                    .ToListAsync();
        }
    }
}
