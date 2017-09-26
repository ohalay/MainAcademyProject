using System.Collections.Generic;
using BusTickets.DataAccess;

    public interface ICityService
    {
        IList<CitiesNearby> GetCitiseNearby(int cityId);
    }
}
