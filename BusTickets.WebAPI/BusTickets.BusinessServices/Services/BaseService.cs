using BusTickets.DataAccess;

namespace BusTickets.BusinessServices.Services
{
    public abstract class BaseService
    {
        private IBusTicketDbContext context;

        public BaseService(IBusTicketDbContext contetx)
        {
            this.context = contetx;
        }

        protected IBusTicketDbContext Context => this.context;
    }
}
