using System.ComponentModel.DataAnnotations;

namespace BusTickets.DataAccess.Models
{
    public class CityNearby
    {
        [Key]
        public int ID { get; set; }

        public int CityID { get; set; }

        public float Distance { get; set; }
    }
}
