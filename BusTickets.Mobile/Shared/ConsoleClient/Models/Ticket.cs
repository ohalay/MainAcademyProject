using System;
using System.Collections.Generic;
using System.Text;

namespace BusTicketClient.Tables
{
    public class Ticket
    {
        public int ID { get; set; }

        public int SeatNumber { get; set; }

        public int JourneyID { get; set; }

        public int CityFromID { get; set; }

        public int CityToID { get; set; }
    }
}
