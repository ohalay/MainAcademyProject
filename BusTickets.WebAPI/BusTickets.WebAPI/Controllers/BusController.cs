using System.Collections.Generic;
using System.Threading.Tasks;
using BusTickets.BusinessServices.Interfices;
using BusTickets.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace BusTickets.WebAPI.Controllers
{
    [Route("api/v1")]
    public class BusController : Controller
    {
        private IBusService buses;

        public BusController(IBusService busService)
        {
            this.buses = busService;
        }

        [HttpGet("buses/{id}")]
        public async Task<IList<Bus>> GetBusAsync(int id)
        {
            return await this.buses.GetBusAsync(id);
        }
    }
}