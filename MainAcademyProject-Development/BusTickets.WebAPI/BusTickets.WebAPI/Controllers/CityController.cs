using System.Collections.Generic;
using System.Threading.Tasks;
using BusTickets.BusinessServices.Interfices;
using BusTickets.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BusTickets.WebAPI.Controllers
{
    public class CityController : Controller
    {
        public CityController(ILoggerFactory logger)
        {
            logger.CreateLogger<CityController>().LogDebug("Controller");
            ////this.cityService = cityService;
        }

        ////[Route("TheSameCityName")]
        ////public async Task<IList<City>> GetTheSameNameAsync(string startwithcity)
        ////{
        ////    return await this.cityService.GetCityAsync(startwithcity);
        ////}
        [HttpGet("api/get")]
        public int Get()
        {
            return 12;
        }
    }
}
