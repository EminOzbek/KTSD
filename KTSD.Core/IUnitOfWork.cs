using System;
using System.Threading.Tasks;
using KTSD.Core.Repository;

namespace KTSD.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IRoleRepository Roles { get; }
        IPageRepository Pages { get; }
        IAnnouncementRepository Announcements { get; }
        IFileRepository Files { get; }
        IProjectRepository Projects { get; }
        IMenuRepository Menus { get; }
        IWorkGroupRepository WorkGroups { get; }
        IEventRepository Events { get; }
        IFolderRepository Folders { get; }
        IMemberRepository Members { get; }
        IUserFileRepository UserFiles { get; }
        IUserFolderRepository UserFolders { get; }
        IBannerRepository Banners { get; }
        IMessageRepository Messages { get; }
        IContactInfoRepository ContactInfos { get; }
        ISettingsRepository Settings { get; }
        IWeeklyInfoRepository WeeklyInfos { get; }
        Task<int> SaveAsync();
    }
}