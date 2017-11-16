using System.Collections.Generic;
using System.Threading.Tasks;
using BusTickets.BusinessServices.Interfices;
using BusTickets.DataAccess;
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

        [HttpPost("tickets/{jorneyId}")]
        public async Task CreateTicketAsync(int jorneyId)
        {
            await this.ticketService.CreateTicketAsync(jorneyId);
        }

        [HttpGet("tickets/{jorneyId}")]
        public async Task<int> GetTicketAsync(int jorneyId)
        {
            return await this.ticketService.GetTicketAsync(jorneyId);
        }
    }
}
