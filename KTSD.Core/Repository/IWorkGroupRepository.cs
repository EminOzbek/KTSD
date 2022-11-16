using System.Threading.Tasks;
using KTSD.Core.Models;

namespace KTSD.Core.Repository
{
    public interface IWorkGroupRepository : IRepository<WorkGroup>
    {
        Task<WorkGroup> GetWorkGroupByIdWithUsers(int id);
    }
}