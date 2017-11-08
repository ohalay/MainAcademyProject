using BusTickets.BusinessServices.Interfices;
using Microsoft.AspNetCore.Mvc;

namespace BusTickets.WebAPI.Controllers
{
    [Route("api/v1")]
    public class BusStopController : Controller
    {
        private IBusStopService busStopS;

        public BusStopController(IBusStopService busStopService)
        {
            this.busStopS = busStopService;
        }

        [HttpGet("busStops/{id}")]
        public IActionResult Get(int id)
        {
            return this.Ok(this.busStopS.GetBusStopAsync(id));
        }
    }
}
