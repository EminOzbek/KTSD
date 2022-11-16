using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core.Models;

namespace KTSD.Core.Repository
{
    public interface IUserFileRepository : IRepository<UserFile>
    {
        Task<IEnumerable<UserFile>> GetFilesByUserId(int userId);
    }
}