using System.Collections.Generic;
using System.Threading.Tasks;
using BusTickets.DataAccess;

namespace BusTickets.BusinessServices.Interfices
{
    public interface ICityService
    {
       Task<IList<City>> GetCityAsync(string startwithcity);
    }
}
