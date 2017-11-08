using System.Collections.Generic;
using System.Threading.Tasks;
using BusTickets.DataAccess;

namespace BusTickets.BusinessServices.Interfices
{
    public interface IBusStopService
    {
        Task<IList<BusStop>> GetBusStopAsync(int jorneyID);
    }
}
