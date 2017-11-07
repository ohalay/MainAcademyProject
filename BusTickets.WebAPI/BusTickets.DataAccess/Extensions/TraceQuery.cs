using System;
using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace BusTickets.DataAccess.Extensions
{
    public class TraceQuery : ILogger
    {
        private readonly string categoryName;

        public TraceQuery(string categoryName) => this.categoryName = categoryName;

        public IDisposable BeginScope<TState>(TState state) => null;

        public bool IsEnabled(LogLevel logLevel) => true;

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            Trace.WriteLine($"{DateTime.Now.ToString("o")} {logLevel} {eventId.Id} {this.categoryName}");
            Trace.WriteLine(formatter(state, exception));
        }
    }
}
