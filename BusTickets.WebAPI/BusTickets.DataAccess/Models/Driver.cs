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
        public string Phone_Number { get; set; }

        [MaxLength(40)]
        public string Address { get; set; }
    }
}
