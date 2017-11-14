using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BusTickets.DataAccess;

namespace BusTickets.BusinessServices.Interfices
{
    public interface ITripService
    {
        Task<IList<Journey>> GetJourneyByDateAsync(DateTime datetime1, DateTime datetime2);
    }
}
