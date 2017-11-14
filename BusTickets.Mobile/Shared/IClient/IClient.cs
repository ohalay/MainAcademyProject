using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shared.IClient
{
    public interface IClient
    {
        [Get("/api/v1/cities/{startwithcity}")]
        Task<IEnumerable<City>> GetCity(string startwithcity);
    }

    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
