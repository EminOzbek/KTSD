using KTSD.Core.Models;
using KTSD.Core.Repository;

namespace KTSD.Data.Repositories
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        private KTSDDbContext KTSDDbContext => Context as KTSDDbContext;

        public ProjectRepository(KTSDDbContext context) : base(context)
        {
        }
    }
}