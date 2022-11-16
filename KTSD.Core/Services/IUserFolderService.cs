using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core.Models;

namespace KTSD.Core.Services
{
    public interface IUserFolderService
    {
        Task SetUserFileAccess(UserFolderRequest model);
        IEnumerable<File> GetFilesByUserId(int userId);
        IEnumerable<FolderListRes> GetFoldersByUserId(int userId);
    }
}