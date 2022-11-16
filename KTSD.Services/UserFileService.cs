using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTSD.Core;
using KTSD.Core.Models;
using KTSD.Core.Services;

namespace KTSD.Services
{
    public class UserFileService : IUserFileService
    {
        private readonly IUnitOfWork _uow;
        private readonly IUserService _userService;

        public UserFileService(IUnitOfWork uow, IUserService userService)
        {
            _uow = uow;
            _userService = userService;
        }

        public async Task<IEnumerable<UserFile>> GetAll()
        {
            return await _uow.UserFiles.GetAllAsync();
        }

        public async Task<UserFile> GetById(int id)
        {
            return await _uow.UserFiles.GetByIdAsync(id);
        }

        public async Task<UserFile> Create(UserFile item)
        {
            await _uow.UserFiles.AddAsync(item);
            await _uow.SaveAsync();
            return await _uow.UserFiles.SingleOrDefaultAsync(p => p.UserId == item.UserId);
        }

        public async Task Update(UserFile item)
        {
            _uow.UserFiles.Update(item);
            await _uow.SaveAsync();
        }

        public async Task Delete(int id)
        {
            var userFile = await _uow.UserFiles.GetByIdAsync(id);
            _uow.UserFiles.Remove(userFile);
            await _uow.SaveAsync();
        }

        public async Task SetUserFileAccess(UserFileRequest model)
        {
            IEnumerable<User> users = new List<User>();
            if (model.Members.Count > 0)
            {
                users = _userService.GetUsersByFilter(p => model.Members.Contains(p.MemberId));
            }

            if (model.Workgroups.Count > 0)
            {
                //users = _userService.GetUsersByFilter(p => model.Workgroups.Contains(p.WorkGroupId ?? 0));
            }

            if (model.Workgroups.Count > 0)
            {
                users = _userService.GetUsersByFilter(p => model.Users.Contains(p.Id));
            }
            
            var folders = _uow.UserFolders.Find(f => f.FolderId == model.FolderId).ToList();
            if (folders.Count > 0)
            {
                _uow.UserFolders.RemoveRange(folders);
            }

            var userFolders = (from user in users
                select new UserFolder() {FolderId = model.FolderId, UserId = user.Id}).ToList();
            
            if (userFolders != null)
            {
                await _uow.UserFolders.AddRangeAsync(userFolders);
                await _uow.SaveAsync();
            }
        }

        public async Task<IEnumerable<UserFile>> GetFilesByUserId(int userId)
        {
            return await _uow.UserFiles.GetFilesByUserId(userId);
        }
    }
}