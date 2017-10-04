using System.Collections.Generic;
using BusTickets.BusinessServices.Interfices;
using BusTickets.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace BusTickets.WebAPI.Controllers
{
    public class CityController : Controller
    {
        private ICitySearchService cityService;

        public CityController(ICitySearchService cityService)
        {
            this.cityService = cityService;
        }

        [Route("TheSameCityName")]
        public IList<City> GetTheSameName(string startwithcity)
        {
            return this.cityService.GetCity(startwithcity);
        }
    }
}
