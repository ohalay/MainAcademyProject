using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusTickets.DataAccess
{
    public class BusStop
    {
        [Key]
        public int ID { get; set; }

        public int CityID { get; set; }

        public int JourneyID { get; set; }

        public int Distance { get; set; }

        public int Time { get; set; }

        public double Price { get; set; }

        public City City { get; set; }

        public Journey Journey { get; set; }
    }
}