using Refit;
using System;
using System.Threading.Tasks;

namespace BusTicketClient.Tables
{
    class Program
    {
        static void Main(string[] args)
    {
        var client = RestService.For<IClient>("http://localhost:55194");

            var resCity = client.GetCity("L").Result;
            var resBusStop = client.GetBusStop(3).Result;
            var resTicket = client.GetTicket(1).Result;
            var resTrip = client.GetJourney(1, 4, 1).Result;
            var resBus = client.GetBus(1).Result;

            Console.WriteLine(resBus);
            Console.WriteLine(resTrip);
            Console.WriteLine(resTicket);
            Console.WriteLine(resCity);
            Console.WriteLine(resBusStop);
            Console.ReadLine();
    }
    }
}
