using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using KTSD.Core.Models;

namespace KTSD.Core.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UserListRes>> GetAllWithRole();
        Task<User> GetUserById(int id);
        Task<User> GetUserByEmail(string email);
        Task<IEnumerable<User>> GetUsersByRoleId(int roleId);
        Task<User> CreateUser(UserCreateReq newUser);
        Task UpdateUser(User user);
        Task DeleteUser(int id);
        IEnumerable<User> GetUsersByFilter(Expression<Func<User, bool>> predicate);
        Task<IEnumerable<User>> GetMembersAndWorkGroupsById(List<int> ids);
        Task<User> GetUserByIdWithWorkgroups(int id);
        Task UpdateUserWorkGroup(IEnumerable<UserWorkGroup> userWorkGroups, int? userId, int? workgroupId);
    }
}