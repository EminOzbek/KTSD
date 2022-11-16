using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTSD.Core;
using KTSD.Core.Models;
using KTSD.Core.Services;

namespace KTSD.Services
{
    public class AnnouncementService : IAnnouncementService
    {
        private readonly IUnitOfWork _uow;

        public AnnouncementService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<Announcement>> GetAll()
        {
            return await _uow.Announcements.GetAllAsync();
        }

        public async Task<Announcement> GetById(int id)
        {
            return await _uow.Announcements.GetByIdAsync(id);
        }

        public async Task<Announcement> Create(Announcement item)
        {
            await _uow.Announcements.AddAsync(item);
            await _uow.SaveAsync();
            return item;
        }

        public async Task Update(Announcement item)
        {
            _uow.Announcements.Update(item);
            await _uow.SaveAsync();
        }

        public async Task Delete(int id)
        {
            var announcement = await _uow.Announcements.GetByIdAsync(id);
            _uow.Announcements.Remove(announcement);
            await _uow.SaveAsync();
        }
    }
}