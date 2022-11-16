using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core;
using KTSD.Core.Models;
using KTSD.Core.Services;

namespace KTSD.Services
{
    public class SettingsService: ISettingsService
    {
        private readonly IUnitOfWork _uow;
        
        public SettingsService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<IEnumerable<Settings>> GetAll()
        {
            return await _uow.Settings.GetAllAsync();
        }

        public async Task<Settings> GetById(int id)
        {
            return await _uow.Settings.GetByIdAsync(id);
        }

        public async Task<Settings> Create(Settings item)
        {
            await _uow.Settings.AddAsync(item);
            await _uow.SaveAsync();
            return await _uow.Settings.SingleOrDefaultAsync(p => p.Id == item.Id);
        }

        public async Task Update(Settings item)
        {
            _uow.Settings.Update(item);
            await _uow.SaveAsync();
        }

        public async Task Delete(int id)
        {
            var settings = await _uow.Settings.GetByIdAsync(id);
            _uow.Settings.Remove(settings);
            await _uow.SaveAsync();
        }

        public async Task<Settings> GetByLangCode(string langCode)
        {
            return await _uow.Settings.SingleOrDefaultAsync(p => p.LangCode == langCode);
        }
    }
}