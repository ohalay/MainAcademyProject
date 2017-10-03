using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusTickets.DataAccess
{
    public class City
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public int People { get; set; }

        public ICollection<BusStop> BusStops { get; set; }

        public ICollection<BusStation> BusStations { get; set; }

        public ICollection<Ticket> CitiesNearbys { get; set; }

        public ICollection<Ticket> CityFrom { get; set; }

        public ICollection<Ticket> CityTo { get; set; }
    }
}
