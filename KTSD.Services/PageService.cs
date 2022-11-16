using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core;
using KTSD.Core.Models;
using KTSD.Core.Services;

namespace KTSD.Services
{
    public class PageService : IPageService
    {
        private readonly IUnitOfWork _uow;

        public PageService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<Page>> GetAll()
        {
            return await _uow.Pages.GetAllAsync();
        }

        public async Task<Page> GetById(int id)
        {
            return await _uow.Pages.GetByIdAsync(id);
        }

        public async Task<Page> Create(Page item)
        {
            await _uow.Pages.AddAsync(item);
            await _uow.SaveAsync();
            return await _uow.Pages.SingleOrDefaultAsync(p => p.Id == item.Id);
        }

        public async Task Update(Page item)
        {
            _uow.Pages.Update(item);
            await _uow.SaveAsync();
        }

        public async Task Delete(int id)
        {
            var page = await _uow.Pages.GetByIdAsync(id);
            _uow.Pages.Remove(page);
            await _uow.SaveAsync();
        }

        public Task<IEnumerable<Page>> GetPagesByStatus(int status)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Page> GetPageBySlug(string slug)
        {
            var page = await _uow.Pages.SingleOrDefaultAsync(p => p.Slug == slug);
            return page;
        }

        public async Task<IEnumerable<PageListRes>> GetPagesWithoutContent()
        {
            return await _uow.Pages.GetPagesWithoutContent();
        }
    }
}