using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using KTSD.Core;
using KTSD.Core.Models;
using KTSD.Core.Services;

namespace KTSD.Services
{
    public class FolderService : IFolderService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public FolderService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Folder>> GetAll()
        {
            return await _uow.Folders.GetAllAsync();
        }

        public IEnumerable<FolderListRes> GetAllWithChildren()
        {
            var folderList = _uow.Folders.FindQuery(p => p.ParentId == 0);
            var result = _mapper.Map<IEnumerable<FolderListRes>>(folderList.ToList());
            GetChildren(result.OrderBy(p => p.OrderIndex));
            return result;
        }
        private void GetChildren(IEnumerable<FolderListRes> parents) {

            foreach (var folder in parents)
            {
                var children = _uow.Folders.FindQuery(f => f.ParentId == folder.Id).OrderBy(p => p.OrderIndex);
                folder.Children = _mapper.Map<IEnumerable<FolderListRes>>(children.ToList());
                GetChildren(folder.Children);
            }
        }
    public async Task<Folder> GetFolderWithFilesById(int id)
    {
        return await _uow.Folders.GetFolderWithFilesById(id);
    }

    public void BulkFolderUpdate(IEnumerable<Folder> folders)
    {
        _uow.Folders.BulkFolderUpdate(folders);
    }

    public async Task<Folder> GetById(int id)
    {
        return await _uow.Folders.GetByIdAsync(id);
    }

    public async Task<Folder> Create(Folder item)
    {
        await _uow.Folders.AddAsync(item);
        await _uow.SaveAsync();
        return item;
    }
    public async Task Update(Folder item)
    {
        _uow.Folders.Update(item);
        await _uow.SaveAsync();
    }

    public async Task Delete(int id)
    {
        var folder = await _uow.Folders.GetByIdAsync(id);
        _uow.Folders.Remove(folder);
        await _uow.SaveAsync();
    }
}
}