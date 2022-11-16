using KTSD.Core.Models;
using KTSD.Core.Repository;
using Microsoft.EntityFrameworkCore;

namespace KTSD.Data.Repositories
{
    public class WeeklyInfoRepository: Repository<WeeklyInfo>, IWeeklyInfoRepository
    {
        public WeeklyInfoRepository(KTSDDbContext context) : base(context)
        {
        }
    }
}