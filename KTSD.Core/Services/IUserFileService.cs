using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core.Models;

namespace KTSD.Core.Services
{
    public interface IUserFileService : ICrudService<UserFile>
    {
        Task SetUserFileAccess(UserFileRequest model);
        Task<IEnumerable<UserFile>> GetFilesByUserId(int userId);
    }
}