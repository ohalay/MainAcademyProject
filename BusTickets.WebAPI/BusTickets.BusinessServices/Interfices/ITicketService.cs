using System.Collections.Generic;
using System.Threading.Tasks;
using BusTickets.DataAccess;

namespace BusTickets.BusinessServices.Interfices
{
    public interface ITicketService
    {
        Task<int> GetTicketAsync(int jorneyId);
    }
}
