using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusTickets.DataAccess
{
    public class BusStop
    {
        [Key]
        public int ID { get; set; }

        public int CityID { get; set; }

        public int JorneyID { get; set; }

        public int Distance { get; set; }

        public int Time { get; set; }

        public double Price { get; set; }

        ////[ForeignKey(nameof(CityID))]
        public City City { get; set; }

        ////[ForeignKey(nameof(JorneyID))]
        public Journey Journey { get; set; }
    }
}
