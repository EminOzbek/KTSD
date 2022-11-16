using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core.Models;

namespace KTSD.Core.Repository
{
    public interface IPageRepository: IRepository<Page>
    {
        Task<IEnumerable<Page>> GetPagesByStatus(int status);
        Task<IEnumerable<PageListRes>> GetPagesWithoutContent();
    }
}