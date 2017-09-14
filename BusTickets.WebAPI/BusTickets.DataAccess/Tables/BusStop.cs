using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusTickets.DataAccess
{
    public class BusStop
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("ID")]
        public int JourneyID { get; set; }

        [ForeignKey("City")]
        public int CityID { get; set; }

        [NotMapped]
        public int Time { get; set; }

        [NotMapped]
        public double Price { get; set; }
    }
}
