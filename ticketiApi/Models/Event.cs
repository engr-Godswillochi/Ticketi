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
        [Required]
        public required string Name { get; set; }
        [Required]
        public required string Description {get; set;}
        [Required]
        public required DateOnly Date { get; set; }
        [Required]
        public required string Location { get; set; }
        [Required]
        public string? Image { get; set; }
        [Required]
        public required string Organizer { get; set;}
        [Required]
        public required DateOnly CreatedOn { get; set; }
        [Required]
        public bool SoldOut {get; set; } = false;
        [Required]
        public int MaxTicketsPerUser { get; set; }
    }
}