using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ticketiApi.Models
{
    public class Ticket
    {
        public int Id { get; set; } // Can be int or string
        [Required]
        public required string Name { get; set; }
        
        public decimal Price { get; set; }
        public TicketType Type{ get; set; } = TicketType.REGULAR;
        public int Available { get; set; }
        public int Total { get; set; }
    }
    public enum TicketType {
        VIP,
        VVIP,
        REGULAR
    }
}