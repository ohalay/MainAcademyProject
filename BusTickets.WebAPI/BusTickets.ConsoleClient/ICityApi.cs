using Refit;
using System.Threading.Tasks;

namespace BusTickets.ConsoleClient
{
    public interface ICityApi
    {
        [Get("/cities/{id}/nearby")]
        Task<string> GetCitiesNearbyByCityId([AliasAs("id")]int cityId);
    }
}
