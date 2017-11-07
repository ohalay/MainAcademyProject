﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusTickets.DataAccess
{
    public class Journey
    {
        [Key]
        public int ID { get; set; }

        public int DepartureStationID { get; set; }

        public int ArrivalStationID { get; set; }

        public int DriverID { get; set; }

        public int BusID { get; set; }

        public float Distance { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

        [ForeignKey(nameof(DepartureStationID))]
        public BusStation DepartureBusStation { get; set; }

        [ForeignKey(nameof(ArrivalStationID))]
        public BusStation ArrivalBusStation { get; set; }

        [ForeignKey(nameof(DriverID))]
        public Driver JourneyDriver { get; set; }

        [ForeignKey(nameof(BusID))]
        public Bus JourneyBus { get; set; }

        public ICollection<Ticket> TicketJourney { get; set; }
    }
}
