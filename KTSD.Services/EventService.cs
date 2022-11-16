using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core;
using KTSD.Core.Models;
using KTSD.Core.Services;

namespace KTSD.Services
{
    public class EventService: IEventService
    {
        private readonly IUnitOfWork _uow;
        
        public EventService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<Event>> GetAll()
        {
            return await _uow.Events.GetAllAsync();
        }

        public async Task<Event> GetById(int id)
        {
            return await _uow.Events.GetByIdAsync(id);
        }

        public async Task<Event> Create(Event item)
        {
            await _uow.Events.AddAsync(item);
            await _uow.SaveAsync();
            return await _uow.Events.SingleOrDefaultAsync(p => p.Id == item.Id);
        }

        public async Task Update(Event item)
        {
            _uow.Events.Update(item);
            await _uow.SaveAsync();
        }

        public async Task Delete(int id)
        {
            var page = await _uow.Events.GetByIdAsync(id);
            _uow.Events.Remove(page);
            await _uow.SaveAsync();
        }
    }
}