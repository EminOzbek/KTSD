using KTSD.Core.Models;
using KTSD.Core.Repository;

namespace KTSD.Data.Repositories
{
    public class SettingsRepository : Repository<Settings>, ISettingsRepository
    {
        public SettingsRepository(KTSDDbContext context) : base(context)
        {
        }
    }
}