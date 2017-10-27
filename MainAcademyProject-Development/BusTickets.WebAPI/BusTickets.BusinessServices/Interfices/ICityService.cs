using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BusTickets.DataAccess;

namespace BusTickets.BusinessServices.Interfices
{
    public interface ICityService
    {
      IList<City> GetCity(string startwithcity);
    }
}
