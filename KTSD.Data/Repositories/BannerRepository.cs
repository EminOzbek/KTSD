using KTSD.Core.Models;
using KTSD.Core.Repository;

namespace KTSD.Data.Repositories
{
    public class BannerRepository: Repository<Banner>, IBannerRepository
    {
        public BannerRepository(KTSDDbContext context) : base(context)
        {
        }
    }
}