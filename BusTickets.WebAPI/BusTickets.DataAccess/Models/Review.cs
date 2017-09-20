using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusTickets.DataAccess
{
    public class Review
    {
        [Key]
        public int ID { get; set; }

        public int Number_Of_Seats { get; set; }

        public int DriverID { get; set; }

        public int Opinion { get; set; }

        [MaxLength(50)]
        public string Explanation { get; set; }

        [ForeignKey(nameof(DriverID))]
        public Driver Driver { get; set; }
    }
}
