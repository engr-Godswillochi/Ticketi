using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ticketiApi.Data;
using ticketiApi.Dto.EventDto;
using ticketiApi.Dtos.EventDto;
using ticketiApi.Interface;
using ticketiApi.Mappers;
using ticketiApi.Models;

namespace ticketiApi.Controllers
{
    [Route("api/event")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventRepository _eventrepo;
        private readonly AppDbContext _context;
        public EventController(IEventRepository eventRepo, AppDbContext context)
        {
            _eventrepo = eventRepo;
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvents()
        {
            return await _context.events.ToListAsync();
            // if (events == null)
            // {
            //     return Ok("No events recorded");
            // }
            // return Ok(events);
        }
        [HttpPost]
        public async Task<IActionResult> create([FromBody] CreateEventDto createvent)
        {
            var eventModel =    createvent.ToCreateEventDto();
            if (eventModel == null)
            {
                return BadRequest("No information added");
            }
            await _context.events.AddAsync(eventModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEvent), new{id = eventModel.Id}, eventModel);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> GetEvent(int id)
        {
            var eventModel = await _context.events.FindAsync(id);
            if (eventModel == null)
            {
                return NotFound();
            }
            return eventModel;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEvent(int id, [FromBody] UpdateEventDto updateEvent)
        {
            if (id != updateEvent.Id)
            {
                return BadRequest();
            }
            var eventModel = await _context.events.FindAsync(id);
            if (eventModel == null)
            {
                return NotFound();
            }
            eventModel.Name = updateEvent.Name;
            eventModel.Date = updateEvent.Date;
            eventModel.Location = updateEvent.Location;
            eventModel.Description = updateEvent.Description;
            eventModel.Image = updateEvent.Image;
            eventModel.SoldOut = updateEvent.SoldOut;
            eventModel.Organizer = updateEvent.Organizer;
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}