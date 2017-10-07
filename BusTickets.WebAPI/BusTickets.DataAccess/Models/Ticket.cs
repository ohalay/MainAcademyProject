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

        public int CityFromID { get; set; }

        public int CityToID { get; set; }

        [ForeignKey(nameof(JourneyID))]
        public Journey TicketJourney { get; set; }

        public City CityFrom { get; set; }

        public City CityTo { get; set; }
    }
}
