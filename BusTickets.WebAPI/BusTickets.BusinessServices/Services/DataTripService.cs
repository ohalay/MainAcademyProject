namespace BusTickets.BusinessServices.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using BusTickets.BusinessServices.Interfices;
    using BusTickets.DataAccess;
    using Microsoft.EntityFrameworkCore;

    public class DataTripService : BaseService, IDataTripService
    {
        public DataTripService(IBusTicketDbContext contetx)
            : base(contetx)
        {
        }

        public IList<Journey> GetJourneyByDate(DateTime dateFrom, DateTime dateTo)
        {
            return this.Context.Journeys
                .AsNoTracking()
                .Where(s => s.DepartureTime >= dateFrom && s.DepartureTime <= dateTo)
                .ToList();
        }
    }
}
