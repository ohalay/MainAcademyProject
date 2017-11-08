using System;
using BusTickets.BusinessServices.Interfices;
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
        public IActionResult Get([FromQuery]DateTime dateFrom, [FromQuery]DateTime dateTo)
        {
            return this.Ok(this.ticketServ.GetJourneyByDateAsync(dateFrom, dateTo));
        }
    }
}
