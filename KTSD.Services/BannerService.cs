using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core;
using KTSD.Core.Models;
using KTSD.Core.Services;

namespace KTSD.Services
{
    public class BannerService : IBannerService
    {
        private readonly IUnitOfWork _uow;

        public BannerService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<Banner>> GetAll()
        {
            return await _uow.Banners.GetAllAsync();
        }

        public async Task<Banner> GetById(int id)
        {
            return await _uow.Banners.GetByIdAsync(id);
        }

        public async Task<Banner> Create(Banner item)
        {
            await _uow.Banners.AddAsync(item);
            await _uow.SaveAsync();
            return item;
        }

        public async Task Update(Banner item)
        {
            _uow.Banners.Update(item);
            await _uow.SaveAsync();
        }

        public async Task Delete(int id)
        {
            var banner = await _uow.Banners.GetByIdAsync(id);
            _uow.Banners.Remove(banner);
            await _uow.SaveAsync();
        }
    }
}