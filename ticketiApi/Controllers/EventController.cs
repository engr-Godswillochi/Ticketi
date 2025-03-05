using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ticketiApi.Data;
using ticketiApi.Interface;
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
        
    }
}