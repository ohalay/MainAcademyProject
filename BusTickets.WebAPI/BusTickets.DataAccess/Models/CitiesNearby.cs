using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusTickets.DataAccess
{
    public class CitiesNearby
    {
        [Key]
        public int ID { get; set; }

        public int JoureyID { get; set; }

        public float Distance { get; set; }

        [ForeignKey(nameof(JoureyID))]
        public City City { get; set; }
    }
}
