using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core;
using KTSD.Core.Models;
using KTSD.Core.Services;

namespace KTSD.Services
{
    public class RoleService : IRoleService
    {
        private readonly IUnitOfWork _uow;

        public RoleService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<Role>> GetAll()
        {
            return await _uow.Roles.GetAllAsync();
        }

        public async Task<Role> GetById(int id)
        {
            return await _uow.Roles.GetByIdAsync(id);
        }

        public async Task<Role> Create(Role item)
        {
            await _uow.Roles.AddAsync(item);
            await _uow.SaveAsync();
            return item;
        }

        public async Task Update(Role item)
        {
            _uow.Roles.Update(item);
            await _uow.SaveAsync();
        }

        public async Task Delete(int id)
        {
            var role = await _uow.Roles.GetByIdAsync(id);
            _uow.Roles.Remove(role);
            await _uow.SaveAsync();
        }
    }
}