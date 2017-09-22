using System.Collections.Generic;
using System.Linq;
using BusTickets.BusinessServices.Interfices;
using BusTickets.DataAccess;
using BusTickets.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace BusTickets.BusinessServices.Services
{
    public class CityService : BaseService, ICityService
    {
        public CityService(IBusTicketDbContext contetx)
            : base(contetx)
        {
        }

        public IList<CityNearby> GetCitiseNearby(int cityId)
        {
            return this.Context.CitiesNearby
                .AsNoTracking()
                .Where(s => s.CityID == cityId)
                .ToList();
        }
    }
}
