using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTSD.Core.Models;
using KTSD.Core.Repository;
using Microsoft.EntityFrameworkCore;

namespace KTSD.Data.Repositories
{
    public class PageRepository : Repository<Page>, IPageRepository
    {
        private KTSDDbContext KTSDDbContext => Context as KTSDDbContext;

        public PageRepository(KTSDDbContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<Page>> GetPagesByStatus(int status)
        {
            return await KTSDDbContext.Pages.Where(p => p.Status == status).ToListAsync();
        }

        public async Task<IEnumerable<PageListRes>> GetPagesWithoutContent()
        {
            return await KTSDDbContext.Pages.Select(p => new PageListRes
            {
                Id = p.Id,
                Title = p.Title,
                Status = p.Status,
                Slug = p.Slug,
                //MenuTitle = KTSDDbContext.NavMenus.FirstOrDefault<NavMenu>(m => m.Slug == p.Slug).Name,
                CreatedAt = p.CreatedAt,
                UpdatedAt = p.UpdatedAt,
            }).ToListAsync();
        }
    }
}