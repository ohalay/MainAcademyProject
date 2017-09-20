using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusTickets.DataAccess
{
    public class CitiesNearby
    {
        [Key]
        public int ID { get; set; }

        public int CityID { get; set; }

        public float Distance { get; set; }

        [ForeignKey(nameof(CityID))]
        public City City { get; set; }
    }
}
