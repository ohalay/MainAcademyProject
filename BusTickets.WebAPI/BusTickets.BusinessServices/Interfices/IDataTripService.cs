namespace BusTickets.BusinessServices.Interfices
{
    using System;
    using System.Collections.Generic;
    using BusTickets.DataAccess;

    public interface IDataTripService
    {
        IList<Journey> GetJourneyByDate(DateTime datetime1, DateTime datetime2);
    }
}
