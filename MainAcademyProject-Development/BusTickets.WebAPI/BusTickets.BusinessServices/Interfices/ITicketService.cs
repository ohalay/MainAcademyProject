using System.Collections.Generic;
using BusTickets.DataAccess;

namespace BusTickets.BusinessServices.Interfices
{
    public interface ITicketService
    {
        IList<Ticket> GetTicket(int jorneyId);
    }
}
