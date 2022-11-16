using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core;
using KTSD.Core.Models;
using KTSD.Core.Repository;
using KTSD.Core.Services;

namespace KTSD.Services
{
    public class FileService : IFileService
    {
        private readonly IUnitOfWork _uow;

        public FileService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<File>> GetAll()
        {
            return await _uow.Files.GetAllAsync();
        }

        public async Task<File> GetById(int id)
        {
            return await _uow.Files.GetByIdAsync(id);
        }

        public async Task<File> Create(File item)
        {
            await _uow.Files.AddAsync(item);
            await _uow.SaveAsync();
            return item;
        }

        public async Task Update(File item)
        {
            _uow.Files.Update(item);
            await _uow.SaveAsync();
        }

        public async Task Delete(int id)
        {
            var file = await _uow.Files.GetByIdAsync(id);
            _uow.Files.Remove(file);
            await _uow.SaveAsync();
        }

        public async Task<IEnumerable<File>> GetFilesByFolder(int folderId)
        {
            return _uow.Files.Find(p => p.FolderId == folderId);
        }

        public async Task<IEnumerable<File>> GetLastUploadedFiles(int UserId, string size){
            return _uow.Files.Find(p => p.Size == size);
        }
        
    }
}