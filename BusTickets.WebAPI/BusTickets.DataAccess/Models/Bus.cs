using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusTickets.DataAccess
{
    public class Bus
    {
        [Key]
        public int ID { get; set; }

        public int SeatsNumber { get; set; }

        public int BusTypeID { get; set; }

        public int BusNumber { get; set; }

        [ForeignKey(nameof(BusTypeID))]
        public BusType BusType { get; set; }

        public ICollection<Journey> JourneyBus { get; set; }
    }
}
