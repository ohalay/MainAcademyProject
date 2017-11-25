using System;
using System.Collections.Generic;
using System.Text;

namespace BusTicketClient.Tables
{
    public class Journey
    {
        public int ID { get; set; }

        public int DepartureStationID { get; set; }

        public int ArrivalStationID { get; set; }

        public int DriverID { get; set; }

        public int BusID { get; set; }

        public float Distance { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

        public string CityNameFrom { get; set; }

        public string CityNameTo { get; set; }
    }
}
