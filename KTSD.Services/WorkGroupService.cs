using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core;
using KTSD.Core.Models;
using KTSD.Core.Services;

namespace KTSD.Services
{
    public class WorkGroupService : IWorkGroupService
    {
        private readonly IUnitOfWork _uow;

        public WorkGroupService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<WorkGroup>> GetAll()
        {
            return await _uow.WorkGroups.GetAllAsync();
        }

        public async Task<WorkGroup> GetById(int id)
        {
            return await _uow.WorkGroups.GetByIdAsync(id);
        }

        public async Task<WorkGroup> Create(WorkGroup item)
        {
            await _uow.WorkGroups.AddAsync(item);
            await _uow.SaveAsync();
            return item;
        }

        public async Task Update(WorkGroup item)
        {
            _uow.WorkGroups.Update(item);
            await _uow.SaveAsync();
        }

        public async Task Delete(int id)
        {
            var workGroup = await _uow.WorkGroups.GetByIdAsync(id);
            _uow.WorkGroups.Remove(workGroup);
            await _uow.SaveAsync();
        }

        public async Task<WorkGroup> GetWorkGroupByIdWithUsers(int id)
        {
            return await _uow.WorkGroups.GetWorkGroupByIdWithUsers(id);
        }
    }
}