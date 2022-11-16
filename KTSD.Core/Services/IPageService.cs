using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core.Models;

namespace KTSD.Core.Services
{
    public interface IPageService: ICrudService<Page>
    {
        Task<IEnumerable<Page>> GetPagesByStatus(int status);
        Task<Page> GetPageBySlug(string slug);
        Task<IEnumerable<PageListRes>> GetPagesWithoutContent();
    }
}