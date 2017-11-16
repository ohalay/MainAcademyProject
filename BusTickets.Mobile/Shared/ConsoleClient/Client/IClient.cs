using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketClient.Tables
{
    public interface IClient
    {
        [Get("/api/v1/cities/{startwithcity}")]
        Task<string> GetCity(string startwithcity);

        [Get("/api/v1/tickets/{jorneyId}")]
        Task<int> GetTicket(int jorneyId);

        [Get("/api/v1/busStops/{id}")]
        Task<IEnumerable<BusStop>> GetBusStop(int id);

        [Get("/api/v1/trips/{jorneyId}")]
        Task<IEnumerable<Journey>> GetJourney(int jorneyId, int arrivalStation, int departueStation);

        [Get("/api/v1/buses/{id}")]
        Task<IEnumerable<Bus>> GetBus(int id);
    }
}
