using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using KTSD.Core.Models;
using KTSD.Core.Repository;
using Microsoft.EntityFrameworkCore;

namespace KTSD.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private KTSDDbContext KTSDDbContext => Context as KTSDDbContext;

        public UserRepository(KTSDDbContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<User>> GetAllWithRoleAsync()
        {
            return await KTSDDbContext.Users
                .Include(m => m.Role)
                .Include(m => m.Member)
                .ToListAsync();
        }

        public async Task<User> GetWithRoleByIdAsync(int id)
        {
            return await KTSDDbContext.Users
                .Include(m => m.Role)
                .SingleOrDefaultAsync(m => m.Id == id);
            ;
        }

        public async Task<IEnumerable<User>> GetAllWithRoleByRoleIdAsync(int roleId)
        {
            return await KTSDDbContext.Users
                .Include(m => m.Role)
                .Where(m => m.RoleId == roleId)
                .ToListAsync();
        }

        public async Task<IEnumerable<User>> GetMembersAndWorkGroupsById(List<int> ids)
        {
            return await KTSDDbContext.Users
                .Include(p => p.Member)
                .Where(p => ids.Contains(p.Id))
                .ToListAsync();
        }

        public async Task<User> GetUserByIdWithWorkgroups(int id)
        {
            return await KTSDDbContext.Users
                .Include(p => p.UserWorkGroups)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task UpdateUserWorkGroup(IEnumerable<UserWorkGroup> userWorkGroups, int? userId, int? workgroupId)
        {
            if (userId != null)
            {
                var userWorkgroups = KTSDDbContext.UserWorkGroups.Where(p => p.UserId == userId);
                KTSDDbContext.UserWorkGroups.RemoveRange(userWorkgroups);
                await KTSDDbContext.UserWorkGroups.AddRangeAsync(userWorkGroups);
            }
            
            if (workgroupId != null)
            {
                var userWorkgroups = KTSDDbContext.UserWorkGroups.Where(p => p.WorkGroupId == workgroupId);
                KTSDDbContext.UserWorkGroups.RemoveRange(userWorkgroups);
                await KTSDDbContext.UserWorkGroups.AddRangeAsync(userWorkGroups);
            }
        }
    }
}