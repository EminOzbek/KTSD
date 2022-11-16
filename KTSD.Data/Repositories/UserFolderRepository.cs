using KTSD.Core.Models;
using KTSD.Core.Repository;

namespace KTSD.Data.Repositories
{
    public class UserFolderRepository: Repository<UserFolder>, IUserFolderRepository
    {
        public UserFolderRepository(KTSDDbContext context) : base(context)
        {
        }
    }
}