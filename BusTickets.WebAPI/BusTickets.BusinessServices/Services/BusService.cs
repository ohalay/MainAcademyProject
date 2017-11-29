using System.Linq;
using System.Threading.Tasks;
using BusTickets.BusinessServices.Interfices;
using BusTickets.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace BusTickets.BusinessServices.Services
{
    public class BusService : BaseService, IBusService
    {
        public BusService(IBusTicketDbContext contetx)
            : base(contetx)
        {
        }

        public async Task<Bus> GetBusAsync(int id)
        {
            return await this.Context.Buses
                .AsNoTracking()
                .Where(s => s.ID == id)
                .FirstAsync();
        }
    }
}