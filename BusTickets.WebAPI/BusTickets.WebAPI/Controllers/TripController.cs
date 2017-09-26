using System;
using Microsoft.AspNetCore.Mvc;

namespace BusTickets.WebAPI.Controllers
{
    [Route("api/v1/trip")]
    public class TripController : Controller
    {
        [HttpGet]
        public IActionResult Get([FromQuery]DateTime dateFrom, DateTime dateTo)
        {
            return this.Ok(10);
        }

        [HttpGet("{DateTime}")]
        public IActionResult Get(DateTime dateTime)
        {
            return this.Ok(DateTime.Now);
        }
    }
}
