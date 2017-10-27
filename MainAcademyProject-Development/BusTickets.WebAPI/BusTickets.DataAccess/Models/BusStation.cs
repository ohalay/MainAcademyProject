using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusTickets.DataAccess
{
    public class BusStation
    {
        [Key]
        public int ID { get; set; }

        public int CityID { get; set; }

        [MaxLength(50)]
        public string Address { get; set; }

        [ForeignKey(nameof(CityID))]
        public City City { get; set; }

        public ICollection<Journey> ArrivalBusStation { get; set; }

        public ICollection<Journey> DepartureBusStation { get; set; }
    }
}
