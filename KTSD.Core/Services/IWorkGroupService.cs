using System.Threading.Tasks;
using KTSD.Core.Models;

namespace KTSD.Core.Services
{
    public interface IWorkGroupService : ICrudService<WorkGroup>
    {
        Task<WorkGroup> GetWorkGroupByIdWithUsers(int id);
    }
}