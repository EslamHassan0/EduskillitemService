using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Service
{
    public partial class ClTicketService
    {
        public int TicketServiceId { get; set; }
        public int TicketId { get; set; }
        public int ServiceId { get; set; }
        public float Price { get; set; }
        public int Qty { get; set; }
        public string Result { get; set; }
        public bool Payed { get; set; }

        public virtual ClService Service { get; set; }
        public virtual ClTicket Ticket { get; set; }
    }
}
