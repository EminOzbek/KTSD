using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core.Models;
using KTSD.Core.Repository;
using Microsoft.EntityFrameworkCore;

namespace KTSD.Data.Repositories
{
    public class FolderRepository : Repository<Folder>, IFolderRepository
    {
        private KTSDDbContext KTSDDbContext => Context as KTSDDbContext;

        public FolderRepository(KTSDDbContext context) : base(context)
        {
        }

        public async Task<Folder> GetFolderWithFilesById(int id)
        {
            return await KTSDDbContext.Folder
                .Include(p => p.UserFolders)
                .Include(p => p.Files)
                .SingleOrDefaultAsync(p => p.Id == id);
        }

        public void BulkFolderUpdate(IEnumerable<Folder> folders)
        {
            KTSDDbContext.Folder.UpdateRange(folders);
        }
    }
}