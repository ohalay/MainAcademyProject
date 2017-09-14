using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusTickets.DataAccess
{
    public class CitiesNearby
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("City")]
        public int CityID { get; set; }

        [NotMapped]
        public float Distance { get; set; }
    }
}
