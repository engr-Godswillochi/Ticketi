using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ticketiApi.Interface;

namespace ticketiApi.Controllers
{
    [Route("api/event")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventRepository _eventrepo;
        public EventController(IEventRepository eventRepo)
        {
            _eventrepo = eventRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetEvents()
        {
            var events = await _eventrepo.GetAllEventsAsync();
            if (events == null)
            {
                return BadRequest("No events recorded");
            }
            return Ok(events);
        }
        
    }
}