using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace BusTickets.WebAPI.Controllers
{
    public class Validator : AbstractValidator<BusController>
    {
        public void BusValidator()
        {
        }
    }
}
