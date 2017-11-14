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

        public async Task<int> GetTicketAsync(int jorneyId)
        {
            var jorney = await this.Context.Journeys
                .Include(s => s.JourneyBus)
                .FirstAsync(s => s.BusID == jorneyId);

            var ticket = new Ticket();
            ticket.CityFromID = jorney.DepartureStationID;
            ticket.CityToID = jorney.ArrivalStationID;
            ticket.JourneyID = jorneyId;
            ticket.SeatNumber = 0;

            var res = this.Context.Tickets.AddAsync(ticket);

            var resTicket = await this.Context.Tickets
                .AsNoTracking()
                .CountAsync(s => s.JourneyID == jorneyId);

            var resBus = await this.Context.Buses
                .AsNoTracking()
                .FirstAsync(s => s.SeatsNumber == jorneyId);

            return resBus.SeatsNumber - resTicket;
        }
    }
}
