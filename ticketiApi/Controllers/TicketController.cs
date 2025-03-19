using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ticketiApi.Data;
using ticketiApi.Dtos.TicketDto;
using ticketiApi.Models;

namespace ticketiApi.Controllers
{
    [Route("api/ticket")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly AppDbContext _context;
        public TicketController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult <IEnumerable<Ticket>>> GetTickets()
        {
            return await _context.tickets.ToListAsync();
        }
        [HttpPost]
        public async Task<IActionResult> create([FromBody] Ticket ticket)
        {
            if (ticket == null)
            {
                return BadRequest("No information added");
            }
            await _context.tickets.AddAsync(ticket);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTickets), new { id = ticket.Id }, ticket);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> update([FromBody] UpdateTicketDto updateTicket, int id)
        {
            var ticket = await _context.tickets.FirstOrDefaultAsync(x => x.Id == id);
            if (ticket == null)
            {
                return NotFound();
            }
            ticket.Name = updateTicket.Name;
            ticket.Price = updateTicket.Price;
            ticket.Type = updateTicket.Type;
            ticket.Available = updateTicket.Available;
            ticket.Total = updateTicket.Total;

            await _context.SaveChangesAsync();
            return Ok(ticket);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicket(int id)
        {
            var ticket = await _context.tickets.FirstOrDefaultAsync(x => x.Id == id);
            
            if (ticket == null)
            {
                return null;
            }
            _context.tickets.Remove(ticket);
            await _context.SaveChangesAsync();
            return Ok();
        }
        
    }
}