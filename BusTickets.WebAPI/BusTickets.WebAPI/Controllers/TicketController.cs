using BusTickets.BusinessServices.Interfices;
using Microsoft.AspNetCore.Mvc;

namespace BusTickets.WebAPI.Controllers
{
    [Route("api")]
    public class TicketController : Controller
    {
        private ITicketService ticketService;

        public TicketController(ITicketService ticketService)
        {
            this.ticketService = ticketService;
        }

        [HttpGet("driver")]
        public IActionResult Get(int jorneyId)
        {
            return this.Ok(this.ticketService.GetTicket(jorneyId));
        }
    }
}
