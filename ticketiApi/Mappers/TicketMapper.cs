using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ticketiApi.Dtos.TicketDto;
using ticketiApi.Models;

namespace ticketiApi.Mappers
{
    public static class TicketMapper
    {
        public static Ticket ToCreateTicketDto (this CreateTicketDto     createTicketDto)
        {
            return new Ticket
            {
                Name = createTicketDto.Name,
                Price = createTicketDto.Price,
                Type = createTicketDto.Type,
                Available = createTicketDto.Available,
                Total = createTicketDto.Total
            };
        }
    }
}