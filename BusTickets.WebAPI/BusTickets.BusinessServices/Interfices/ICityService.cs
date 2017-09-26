using System.Collections.Generic;
using BusTickets.DataAccess;

namespace BusTickets.BusinessServices.Interfices
{
    public interface ICityService
    {
        IList<CitiesNearby> GetCitiseNearby(int cityId);
    }
}