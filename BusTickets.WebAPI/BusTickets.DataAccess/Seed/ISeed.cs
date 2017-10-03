namespace BusTickets.DataAccess.Seed
{
    internal interface ISeed
    {
        void Seed(IBusTicketDbContext context);
    }
}
