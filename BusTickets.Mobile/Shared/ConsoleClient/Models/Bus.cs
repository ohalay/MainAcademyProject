using System;
using System.Collections.Generic;
using System.Text;

namespace BusTicketClient.Tables
{
    public class Bus
    {
        public int ID { get; set; }

        public int SeatsNumber { get; set; }

        public int BusTypeID { get; set; }

        public int BusNumber { get; set; }
    }
}
