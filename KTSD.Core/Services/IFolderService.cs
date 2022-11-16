using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTSD.Core.Models;

namespace KTSD.Core.Services
{
    public interface IFolderService : ICrudService<Folder>
    {
        IEnumerable<FolderListRes> GetAllWithChildren();
        Task<Folder> GetFolderWithFilesById(int id);
        void BulkFolderUpdate(IEnumerable<Folder> folders);
    }
}