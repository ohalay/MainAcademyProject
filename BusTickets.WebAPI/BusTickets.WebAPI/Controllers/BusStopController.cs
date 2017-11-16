using System.Collections.Generic;
using System.Threading.Tasks;
using BusTickets.BusinessServices.Interfices;
using BusTickets.DataAccess;
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
        public async Task<IList<BusStop>> GetBusStopAsync(int id)
        {
            return await this.busStopS.GetBusStopAsync(id);
        }
    }
}
