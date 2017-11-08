using System.Collections.Generic;
using System.Threading.Tasks;
using BusTickets.BusinessServices.Interfices;
using BusTickets.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BusTickets.WebAPI.Controllers
{
    [Route("api/v1")]
    public class CityController : Controller
    {
        private ICityService cityService;

        public CityController(ICityService cityService)
        {
            this.cityService = cityService;
        }

        [HttpGet("/cities/{startwithcity}")]
        public async Task<IList<City>> GetTheSameNameAsync(string startwithcity)
        {
            return await this.cityService.GetCityAsync(startwithcity);
        }
    }
}
