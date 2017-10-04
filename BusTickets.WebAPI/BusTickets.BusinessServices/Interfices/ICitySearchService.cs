using System;
using System.Collections.Generic;
using BusTickets.DataAccess;

namespace BusTickets.BusinessServices.Interfices
{
    public interface ICitySearchService
    {
        IList<City> GetCity(string startwithcity);
    }
}
