using BusTickets.BusinessServices.Interfices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace BusTickets.WebAPI.Controllers
{
    [Route("api/v1/cities")]
    public class CityController : Controller
    {
        private readonly ICityService cityService;
        private readonly ILogger<CityController> logger;
        private readonly IOptions<MyOption> options;

        public CityController(ICityService cityService, ILogger<CityController> logger, IOptions<MyOption> options)
        {
            this.cityService = cityService;
            this.logger = logger;
            this.options = options;
        }

        [HttpGet("{cityId}/nearby")]
        public IActionResult Get(int cityId)
        {
            this.logger.LogTrace("City controller....");
            return this.Ok(this.cityService.GetCitiseNearby(cityId));
        }
    }
}
