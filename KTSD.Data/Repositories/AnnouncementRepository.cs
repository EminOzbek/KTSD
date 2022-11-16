using KTSD.Core.Models;
using KTSD.Core.Repository;

namespace KTSD.Data.Repositories
{
    
    public class AnnouncementRepository: Repository<Announcement>, IAnnouncementRepository
    {
        public AnnouncementRepository(KTSDDbContext context)
            : base(context)
        {
        }
    }
}