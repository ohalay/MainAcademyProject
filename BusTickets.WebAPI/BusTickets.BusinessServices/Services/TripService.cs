using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusTickets.BusinessServices.Interfices;
using BusTickets.BusinessServices.Services;
using BusTickets.DataAccess;
using Microsoft.EntityFrameworkCore;

public class TripService : BaseService, ITripService
    {
        public TripService(IBusTicketDbContext contetx)
            : base(contetx)
        {
        }

        public async Task<IEnumerable<Journey>> GetJourneyByDateAsync(int arrivalStation, int departueStation)
        {
            return await this.Context.Journeys
                    .AsNoTracking()
                    .Where(s => s.ArrivalStationID == arrivalStation && s.DepartureStationID == departueStation)
                    .ToListAsync();
        }
    }