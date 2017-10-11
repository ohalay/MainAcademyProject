﻿using System.Collections.Generic;
using System.Linq;
using BusTickets.BusinessServices.Interfices;
using BusTickets.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace BusTickets.BusinessServices.Services
{
    public class CityNearbyService : BaseService, ICityNearbyService
    {
        public CityNearbyService(IBusTicketDbContext contetx)
            : base(contetx)
        {
        }

        public IList<CitiesNearby> GetCitiseNearby(int cityId)
        {
            return this.Context.CitiesNearbys
                .AsNoTracking()
                .Where(s => s.CityID == cityId)
                .ToList();
        }
    }
}
