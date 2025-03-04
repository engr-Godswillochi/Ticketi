using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ticketiApi.Models;

namespace ticketiApi.Interface
{
    public interface IEventRepository
    {
        Task<List<Event>> GetAllEventsAsync();
    }
}