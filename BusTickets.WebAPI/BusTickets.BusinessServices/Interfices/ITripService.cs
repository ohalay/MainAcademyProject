using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BusTickets.DataAccess;

namespace BusTickets.BusinessServices.Interfices
{
    public interface ITripService
    {
        Task<IEnumerable<Journey>> GetJourneyByDateAsync(int arrivalStation, int departueStation);
    }
}
