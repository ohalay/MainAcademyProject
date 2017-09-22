using System.Collections.Generic;
using BusTickets.DataAccess.Models;

namespace BusTickets.BusinessServices.Interfices
{
    public interface ICityService
    {
        IList<CityNearby> GetCitiseNearby(int cityId);
    }
}
