using System.Collections.Generic;
using System.Linq;
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

        public IList<Ticket> GetTicket(int jorneyId)
        {
            return this.Context.Tickets
                .AsNoTracking()
                .Where(s => s.JourneyID == jorneyId)
                .ToList();
        }
    }
}
