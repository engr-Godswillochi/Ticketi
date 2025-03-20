using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ticketiApi.Models;

namespace ticketiApi.Mappers
{
    public static class TicketMapper
    {
        public static Ticket ToUpdateTicketDto (this UpdateTicket updateTicket)
        {
            return new Ticket
            {
                Name = updateTicket.Name,
                Price = updateTicket.Price,
                Type = updateTicket.Type,
                Available = updateTicket.Available,
                Total = updateTicket.Total
            };
        }
    }
}