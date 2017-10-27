using System.Collections.Generic;
using BusTickets.DataAccess;

namespace BusTickets.BusinessServices.Interfices
{
    public interface IBusStopService
    {
        IList<BusStop> GetBusStop(int jorneyID);
    }
}
