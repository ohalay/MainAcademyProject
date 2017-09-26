using Microsoft.AspNetCore.Mvc;

namespace BusTickets.WebAPI.Controllers
{
    public class BusStopController : Controller
    {
        [Route("busStops/{id}")]
        public IActionResult Get(int id)
        {
            return this.Ok(id);
        }
    }
}
