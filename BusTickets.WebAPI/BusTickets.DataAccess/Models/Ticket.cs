using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusTickets.DataAccess
{
    public class Ticket
    {
        [Key]
        public int ID { get; set; }

        public int SeatNumber { get; set; }

        public int JourneyID { get; set; }

        public int DriverID { get; set; }

        public int BusID { get; set; }

        public int CityFromID { get; set; }

        public int CityToID { get; set; }

        public Journey JourneyT { get; set; }

        public Driver DriverT { get; set; }

        public Bus BusT { get; set; }

        public City CityFromT { get; set; }

        public City CityToT { get; set; }
    }
}
