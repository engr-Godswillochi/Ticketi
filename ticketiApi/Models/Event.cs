using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ticketiApi.Models
{
    [Table("Events")]
    public class Event
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description {get; set;}
        public required DateOnly Date { get; set; }
        public required string Location { get; set; }
        public string? Image { get; set; }
        public string? Organizer { get; set;}
        public  DateOnly? CreatedOn { get; set; }
        public bool SoldOut {get; set; } = false;
        public int MaxTicketsPerUser { get; set; }
    }
}