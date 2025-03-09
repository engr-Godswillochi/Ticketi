using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ticketiApi.Dto.EventDto;
using ticketiApi.Dtos.EventDto;
using ticketiApi.Models;

namespace ticketiApi.Mappers
{
    public static class EventMapper
    {
        public static Event ToCreateEventDto(this CreateEventDto createEventDto)
        {
            return new Event 
            {
                Name = createEventDto.Name,
                Date = createEventDto.Date,
                Location = createEventDto.Location,
                Description = createEventDto.Description,
                Image = createEventDto.Image,
                SoldOut = createEventDto.SoldOut,
                Organizer = createEventDto.Organizer,
                CreatedOn = DateOnly.FromDateTime(DateTime.Now),
                MaxTicketsPerUser = createEventDto.MaxTicketsPerUser,
            };
        }

    }
}