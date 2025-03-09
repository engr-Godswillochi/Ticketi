using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ticketiApi.Dtos.EventDto
{
    public class EventDto
    {
        public string Name {get; set;}
        public DateOnly Date { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool SoldOut { get; set; }
        public string Organizer { get; set; }
    }
}