using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BusTickets.BusinessServices.Interfices;
using BusTickets.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace BusTickets.WebAPI.Controllers
{
    [Route("api/v1")]
    public class TripController : Controller
    {
        private ITripService ticketServ;

        public TripController(ITripService ticketService)
        {
            this.ticketServ = ticketService;
        }

        [HttpGet("trips/{jorneyId}")]
        public async Task<IList<Journey>> GetJourneyByDateAsync([FromQuery]int arrivalStation, [FromQuery]int departueStation)
        {
            return await this.ticketServ.GetJourneyByDateAsync(arrivalStation, departueStation);
        }
    }
}
