using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace BusTickets.WebAPI.ExceptionHandler
{
    public sealed class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger logger;

        public ExceptionHandlerMiddleware(
            RequestDelegate next,
            ILoggerFactory loggerFactory)
        {
            this.next = next;
            this.logger = loggerFactory.
                    CreateLogger<ExceptionHandlerMiddleware>();
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await this.next(context);
            }
            catch (Exception ex)
            {
                try
                {
                    this.logger.LogInformation(" some information ", ex);
                }
                catch (Exception ex2)
                {
                    this.logger.LogError(
                        0, ex2, "An exception was thrown attempting " + "to execute the error handler.");
                }

                throw;
            }
        }
    }
}
