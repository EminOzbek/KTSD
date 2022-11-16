using KTSD.Core.Models;
using KTSD.Core.Repository;

namespace KTSD.Data.Repositories
{
    public class MenuRepository : Repository<NavMenu>, IMenuRepository
    {
        private KTSDDbContext KTSDDbContext => Context as KTSDDbContext;

        public MenuRepository(KTSDDbContext context) : base(context)
        {
        }
    }
}