using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core.Models;

namespace KTSD.Core.Repository
{
    public interface IFolderRepository : IRepository<Folder>
    {
        Task<Folder> GetFolderWithFilesById(int id);
        void BulkFolderUpdate(IEnumerable<Folder> folders);
    }
}