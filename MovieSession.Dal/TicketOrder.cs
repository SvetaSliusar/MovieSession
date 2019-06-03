using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSession.Dal
{
    public enum DeliveryType
    {
        twoD,
        threeD
    }

    public class TicketOrder
    {     
        public int TicketOrderId { get; set; }
        Movie Movie { get; set; }
        CinemaHall CinemaHall { get; set; }
        public int Place { get; set; }
        public DateTime Session { get; set; }
        public DeliveryType DeliveryType { get; set; }
    }
}
