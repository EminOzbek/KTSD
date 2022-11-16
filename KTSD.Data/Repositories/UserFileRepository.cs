using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTSD.Core.Models;
using KTSD.Core.Repository;
using Microsoft.EntityFrameworkCore;

namespace KTSD.Data.Repositories
{
    public class UserFileRepository : Repository<UserFile>, IUserFileRepository
    {
        private KTSDDbContext KTSDDbContext => Context as KTSDDbContext;

        public UserFileRepository(KTSDDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<UserFile>> GetFilesByUserId(int userId)
        {
            return await KTSDDbContext.UserFiles
                .Include(p => p.File)
                .Where(p => p.UserId == userId)
                .ToListAsync();
        }
    }
}