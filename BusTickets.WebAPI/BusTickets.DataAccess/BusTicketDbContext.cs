using Microsoft.EntityFrameworkCore;

namespace BusTickets.DataAccess
{
    public class BusTicketDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = @"Server=.;Database=BusTicket;Trusted_Connection=True;";
            var retryLogicCount = 3;

            optionsBuilder.UseSqlServer(connection, opton => opton.EnableRetryOnFailure(retryLogicCount));
        }
    }
}
