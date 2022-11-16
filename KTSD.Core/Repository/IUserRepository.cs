using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using KTSD.Core.Models;

namespace KTSD.Core.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        Task<IEnumerable<User>> GetAllWithRoleAsync();
        Task<User> GetWithRoleByIdAsync(int id);
        Task<IEnumerable<User>> GetAllWithRoleByRoleIdAsync(int roleId);
        Task<IEnumerable<User>> GetMembersAndWorkGroupsById(List<int> ids);
        Task<User> GetUserByIdWithWorkgroups(int id);
        Task UpdateUserWorkGroup(IEnumerable<UserWorkGroup> userWorkGroups, int? userId, int? workgroupId);
    }
}