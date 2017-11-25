using System;
using System.Collections.Generic;
using System.Text;

namespace BusTicketClient.Tables
{
    public class BusStop
    {
        public int ID { get; set; }

        public int CityID { get; set; }

        public int JourneyID { get; set; }

        public int Distance { get; set; }

        public int Time { get; set; }

        public double Price { get; set; }

    }
}
