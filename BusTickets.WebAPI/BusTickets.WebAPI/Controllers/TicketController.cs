using BusTickets.BusinessServices.Interfices;
using Microsoft.AspNetCore.Mvc;

namespace BusTickets.WebAPI.Controllers
{
    [Route("api/v1")]
    public class TicketController : Controller
    {
        private ITicketService ticketService;

        public TicketController(ITicketService ticketService)
        {
            this.ticketService = ticketService;
        }

        [HttpGet("tickets/{jorneyId}")]
        public IActionResult Get(int jorneyId)
        {
            return this.Ok(this.ticketService.GetTicketAsync(jorneyId));
        }
    }
}
