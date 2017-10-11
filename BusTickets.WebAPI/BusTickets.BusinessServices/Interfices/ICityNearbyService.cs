using System.Collections.Generic;
using BusTickets.DataAccess;

namespace BusTickets.BusinessServices.Interfices
{
    public interface ICityNearbyService
    {
        IList<CitiesNearby> GetCitiseNearby(int cityId);
    }
}