using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ticketiApi.Models;

namespace ticketiApi.Dtos.TicketDto
{
    public class UpdateTicketDto
    {
        public required string Name { get; set; }

        public decimal Price { get; set; }
        public TicketType Type{ get; set; } = TicketType.REGULAR;
        public int Available { get; set; }
        public int Total { get; set; }
    }

}