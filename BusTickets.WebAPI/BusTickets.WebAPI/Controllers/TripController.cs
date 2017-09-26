using System;
using Microsoft.AspNetCore.Mvc;

namespace BusTickets.WebAPI.Controllers
{
    [Route("api/v1/trip")]
    public class TripController : Controller
    {
        [HttpGet]
        public IActionResult Get([FromQuery]DateTime dateTime1, DateTime dateTime2)
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
