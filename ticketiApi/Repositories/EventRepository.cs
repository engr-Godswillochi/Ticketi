using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ticketiApi.Data;
using ticketiApi.Interface;
using ticketiApi.Models;

namespace ticketiApi.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly AppDbContext _context;
        public EventRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Event>> GetAllEventsAsync()
        {
            return await _context.events.ToListAsync();
        }
    }
}