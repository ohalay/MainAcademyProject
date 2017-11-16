﻿using System.Collections.Generic;
using System.Threading.Tasks;
using BusTickets.DataAccess;

namespace BusTickets.BusinessServices.Interfices
{
    public interface ITicketService
    {
        Task CreateTicketAsync(int jorneyId);

        Task<int> GetTicketAsync(int jorneyId);
    }
}
