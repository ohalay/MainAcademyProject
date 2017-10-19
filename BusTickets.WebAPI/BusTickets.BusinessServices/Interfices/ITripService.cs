using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BusTickets.DataAccess;

namespace BusTickets.BusinessServices.Interfices
{
    public interface ITripService
    {
        Task<List<Journey>> GetJourneyByDate(DateTime datetime1, DateTime datetime2);
    }
}
