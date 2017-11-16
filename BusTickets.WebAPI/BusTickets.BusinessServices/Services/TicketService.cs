using System.Collections.Generic;
using System.Threading.Tasks;
using BusTickets.BusinessServices.Interfices;
using BusTickets.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace BusTickets.BusinessServices.Services
{
    public class TicketService : BaseService, ITicketService
    {
        public TicketService(IBusTicketDbContext contetx)
            : base(contetx)
        {
        }

        public async Task CreateTicketAsync(int jorneyId)
        {
            var jorney = await this.Context.Journeys
                .FirstAsync(s => s.ID == jorneyId);

            var ticket = new Ticket();
            ticket.CityFromID = jorney.DepartureStationID;
            ticket.CityToID = jorney.ArrivalStationID;
            ticket.JourneyID = jorneyId;
            ticket.SeatNumber = 0;

            var res = await this.Context.Tickets.AddAsync(ticket);

            await this.Context.SaveChangesAsync();
        }

        public async Task<int> GetTicketAsync(int jorneyId)
        {
            var resTicket = await this.Context.Tickets
                .AsNoTracking()
                .CountAsync(s => s.JourneyID == jorneyId);

            var resBus = await this.Context.Journeys
                .AsNoTracking()
                .Include(s => s.JourneyBus)
                .FirstAsync(s => s.ID == jorneyId);

            return resBus.JourneyBus.SeatsNumber - resTicket;
        }
    }
}
