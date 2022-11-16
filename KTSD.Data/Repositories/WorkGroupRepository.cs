using System.Threading.Tasks;
using KTSD.Core.Models;
using KTSD.Core.Repository;
using Microsoft.EntityFrameworkCore;

namespace KTSD.Data.Repositories
{
    public class WorkGroupRepository : Repository<WorkGroup>, IWorkGroupRepository
    {
        private KTSDDbContext KTSDDbContext => Context as KTSDDbContext;

        public WorkGroupRepository(KTSDDbContext context) : base(context)
        {
        }

        public async Task<WorkGroup> GetWorkGroupByIdWithUsers(int id)
        {
            return await KTSDDbContext.WorkGroups.Include(p => p.UserWorkGroups).FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}