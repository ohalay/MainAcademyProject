using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusTickets.DataAccess
{
    public class Driver
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        [MaxLength(40)]
        public string Address { get; set; }

        public ICollection<Ticket> TicketDriver { get; set; }
    }
}
