using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ticketiApi.Dto.EventDto
{
    public class CreateEventDto
    {
    public string Name { get; set; }
    public string Date { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public bool SoldOut { get; set; }
    public string Organizer { get; set; }
    public string CreatedAt { get; set; }
    public string Category { get; set; }
    }
}