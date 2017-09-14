using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusTickets.DataAccess
{
    public class Journey
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("BusStation")]
        public int DepartureStationID { get; set; }

        [ForeignKey("BusStation")]
        public int ArrivalStationID { get; set; }

        [NotMapped]
        public float Distance { get; set; }

        [NotMapped]
        public DateTime DepartureTime { get; set; }

        [NotMapped]
        public DateTime ArrivalTime { get; set; }
    }
}
