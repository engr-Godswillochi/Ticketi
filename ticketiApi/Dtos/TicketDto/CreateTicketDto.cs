using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ticketiApi.Dtos.TicketDto
{
    public class CreateTicketDto
    {
    public object Id { get; set; } // Can be int or string
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Type { get; set; } // "REGULAR", "VIP", "VVIP" or other
    public int Available { get; set; }
    public int Total { get; set; }
    }
}