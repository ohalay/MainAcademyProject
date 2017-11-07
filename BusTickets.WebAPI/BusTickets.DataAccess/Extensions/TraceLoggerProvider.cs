using Microsoft.Extensions.Logging;

namespace BusTickets.DataAccess.Extensions
{
    public class TraceLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName) => new TraceQuery(categoryName);

        public void Dispose()
        {
        }
    }
}
