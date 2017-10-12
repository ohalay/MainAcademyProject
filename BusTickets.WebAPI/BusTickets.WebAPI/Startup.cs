﻿using BusTickets.BusinessServices.Interfices;
using BusTickets.BusinessServices.Services;
using BusTickets.DataAccess;
using BusTickets.WebAPI.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BusTickets.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<IBusTicketDbContext, BusTicketDbContext>();
            services.AddTransient<IBusStopService, BusStopService>();
            services.AddTransient<ITicketService, TicketService>();
            services.AddTransient<ICitySearchService, CitySearchService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddLog4Net();
            app.UseMvc();
        }
    }
}
