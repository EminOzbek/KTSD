using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core.Models;

namespace KTSD.Core.Services
{
    public interface IFileService: ICrudService<File>
    {
        Task<IEnumerable<File>> GetFilesByFolder(int folderId);

        Task<IEnumerable<File>> GetLastUploadedFiles(int userId, string size);
    }
}