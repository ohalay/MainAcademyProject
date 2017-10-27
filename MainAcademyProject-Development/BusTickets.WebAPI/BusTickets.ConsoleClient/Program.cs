using Refit;
using System;
using System.Threading.Tasks;

namespace BusTickets.ConsoleClient
{
    class Program
    {
        private static string server = "http://localhost:55194";
        private static string api = "api";
        private static string version = "v1";

        static async Task Main(string[] args)
        {
            Console.ReadKey();

            var hostUrl = $"{server}/{api}/{version}";
            var cityApi = RestService.For<ICityApi>(hostUrl);

            var cityId = 1;
            var res = await cityApi.GetCitiesNearbyByCityId(cityId);
          
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
