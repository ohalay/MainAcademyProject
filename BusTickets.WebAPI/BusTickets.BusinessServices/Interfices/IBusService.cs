using System.Threading.Tasks;
using BusTickets.DataAccess;

namespace BusTickets.BusinessServices.Interfices
{
    public interface IBusService
    {
        Task<Bus> GetBusAsync(int id);
    }
}