using System.Collections.Generic;
using System.Threading.Tasks;
using BusTickets.DataAccess;

namespace BusTickets.BusinessServices.Interfices
{
    public interface ICityNearbyService
    {
        Task<IList<CitiesNearby>> GetCitiseNearbyAsync(int cityId);
    }
}