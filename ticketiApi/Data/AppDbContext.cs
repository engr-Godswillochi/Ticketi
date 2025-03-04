using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ticketiApi.Models;

namespace ticketiApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :   base(options)
        {

        }
        
        public DbSet<Event> events {get; set;}
        public DbSet<Ticket> tickets {get; set;}
        

    }
}
