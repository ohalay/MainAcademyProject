using BusTickets.BusinessServices.Interfices;
using Microsoft.AspNetCore.Mvc;

namespace BusTickets.WebAPI.Controllers
{
    public class BusStopController : Controller
    {
        private IBusStopService busStopS;

        public BusStopController(IBusStopService busStopService)
        {
            this.busStopS = busStopService;
        }

        [Route("busStops/{id}")]
        public IActionResult Get(int id)
        {
            return this.Ok(this.busStopS.GetBusStop(id));
        }
    }
}
