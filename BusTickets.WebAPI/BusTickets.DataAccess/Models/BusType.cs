using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusTickets.DataAccess
{
    public class BusType
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Bus> Bus { get; set; }
    }
}
