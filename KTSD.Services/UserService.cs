using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using KTSD.Core;
using KTSD.Core.Models;
using KTSD.Core.Services;

namespace KTSD.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public UserService(IMapper mapper, IUnitOfWork uow)
        {
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<IEnumerable<UserListRes>> GetAllWithRole()
        {
            var userList = await _uow.Users.GetAllWithRoleAsync();
            var result = _mapper.Map<IEnumerable<UserListRes>>(userList);
            return result;
        }

        public async Task<User> GetUserById(int id)
        {
            return await _uow.Users.GetByIdAsync(id);
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _uow.Users.SingleOrDefaultAsync(f => f.Email == email);
        }

        public async Task<IEnumerable<User>> GetUsersByRoleId(int roleId)
        {
            return await _uow.Users.GetAllWithRoleByRoleIdAsync(roleId);
        }

        public async Task<User> CreateUser(UserCreateReq newUser)
        {
            var user = _mapper.Map<User>(newUser);
            await _uow.Users.AddAsync(user);
            await _uow.SaveAsync();
            return await _uow.Users.SingleOrDefaultAsync(user => user.Email == newUser.Email);
        }

        public async Task UpdateUser(User user)
        {
            _uow.Users.Update(user);
            await _uow.SaveAsync();
        }

        public async Task DeleteUser(int id)
        {
            var user = await _uow.Users.GetByIdAsync(id);
            _uow.Users.Remove(user);
            await _uow.SaveAsync();
        }

        public IEnumerable<User> GetUsersByFilter(Expression<Func<User, bool>> predicate)
        {
            return _uow.Users.Find(predicate);
        }

        public async Task<IEnumerable<User>> GetMembersAndWorkGroupsById(List<int> ids)
        {
            return await _uow.Users.GetMembersAndWorkGroupsById(ids);
        }

        public async Task<User> GetUserByIdWithWorkgroups(int id)
        {
            return await _uow.Users.GetUserByIdWithWorkgroups(id);
        }

        public async Task UpdateUserWorkGroup(IEnumerable<UserWorkGroup> userWorkGroups, int? userId, int? workgroupId)
        {
            await _uow.Users.UpdateUserWorkGroup(userWorkGroups,userId, workgroupId);
            await _uow.SaveAsync();
        }
    }
}