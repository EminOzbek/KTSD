using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using KTSD.Core;
using KTSD.Core.Models;
using KTSD.Core.Services;

namespace KTSD.Services
{
    public class UserFolderService : IUserFolderService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public UserFolderService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task SetUserFileAccess(UserFolderRequest model)
        {
            IEnumerable<User> users = new List<User>();
            
            if (model.Users.Count > 0)
            {
                users = _uow.Users.Find(p => model.Users.Contains(p.Id));
            }
            
            if (model.Members.Count > 0)
            {
                users = _uow.Users.Find(p => model.Members.Contains(p.MemberId));
            }

            if (model.Workgroups.Count > 0)
            {
                //users = _uow.Users.Find(p => model.Workgroups.Contains(p.WorkGroupId ?? 0));
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

        public IEnumerable<File> GetFilesByUserId(int userId) 
        {
            var userFolders = _uow.UserFolders
                .Find(f => f.UserId == userId)
                .Select(s => s.FolderId);

            return _uow.Files.Find(f => userFolders.Contains(f.FolderId));
        }

        public IEnumerable<FolderListRes> GetFoldersByUserId(int userId)
        {
            var userFolders = _uow.UserFolders
                .Find(f => f.UserId == userId)
                .Select(s => s.FolderId);
            
            var result = _mapper.Map<IEnumerable<FolderListRes>>(_uow.Folders.Find(f => f.ParentId == 0 && userFolders.Contains(f.Id)));
            foreach (var folder in result)
            {
                var children = _uow.Folders.Find(f => f.ParentId == folder.Id);
                folder.Children = _mapper.Map<IEnumerable<FolderListRes>>(children);
            }

            return result;
        }
    }
}