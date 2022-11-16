using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core;
using KTSD.Core.Models;
using KTSD.Core.Services;

namespace KTSD.Data.Repositories
{
    public class ProjectService : IProjectService
    {
        private readonly IUnitOfWork _uow;

        public ProjectService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<Project>> GetAll()
        {
            return await _uow.Projects.GetAllAsync();
        }

        public async Task<Project> GetById(int id)
        {
            return await _uow.Projects.GetByIdAsync(id);
        }

        public async Task<Project> Create(Project item)
        {
            await _uow.Projects.AddAsync(item);
            await _uow.SaveAsync();
            return item;
        }

        public async Task Update(Project item)
        {
            _uow.Projects.Update(item);
            await _uow.SaveAsync();
        }

        public async Task Delete(int id)
        {
            var project = await _uow.Projects.GetByIdAsync(id);
            _uow.Projects.Remove(project);
            await _uow.SaveAsync();
        }
    }
}