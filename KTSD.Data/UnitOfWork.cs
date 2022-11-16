using System.Threading.Tasks;
using KTSD.Core;
using KTSD.Core.Repository;
using KTSD.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace KTSD.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly KTSDDbContext _context;
        private UserRepository _userRepository;
        private RoleRepository _roleRepository;
        private PageRepository _pageRepository;
        private AnnouncementRepository _announcementRepository;
        private FileRepository _fileRepository;
        private ProjectRepository _projectRepository;
        private MenuRepository _menuRepository;
        private WorkGroupRepository _workGroupRepository;
        private EventRepository _eventRepository;
        private IFolderRepository _folderRepository;
        private IMemberRepository _memberRepository;
        private IUserFileRepository _userFileRepository;
        private IUserFolderRepository _userFolderRepository;
        private IBannerRepository _bannerRepository;
        private IMessageRepository _messageRepository;
        private IContactInfoRepository _contactInfoRepository;
        private ISettingsRepository _settingsRepository;
        private IWeeklyInfoRepository _weeklyInfoRepository;

        public UnitOfWork(KTSDDbContext context)
        {
            _context = context;
        }

        public IUserRepository Users => _userRepository = _userRepository ?? new UserRepository(_context);

        public IRoleRepository Roles => _roleRepository = _roleRepository ?? new RoleRepository(_context);
        public IPageRepository Pages => _pageRepository = _pageRepository ?? new PageRepository(_context);

        public IProjectRepository Projects =>
            _projectRepository = _projectRepository ?? new ProjectRepository(_context);

        public IMenuRepository Menus => _menuRepository = _menuRepository ?? new MenuRepository(_context);

        public IWorkGroupRepository WorkGroups =>
            _workGroupRepository = _workGroupRepository ?? new WorkGroupRepository(_context);

        public IAnnouncementRepository Announcements => _announcementRepository =
            _announcementRepository ?? new AnnouncementRepository(_context);

        public IEventRepository Events => _eventRepository = _eventRepository ?? new EventRepository(_context);
        public IFolderRepository Folders => _folderRepository = _folderRepository ?? new FolderRepository(_context);

        public IFileRepository Files => _fileRepository = _fileRepository ?? new FileRepository(_context);

        public IMemberRepository Members => _memberRepository = _memberRepository ?? new MemberRepository(_context);

        public IUserFileRepository UserFiles =>
            _userFileRepository = _userFileRepository ?? new UserFileRepository(_context);

        public IUserFolderRepository UserFolders =>
            _userFolderRepository = _userFolderRepository ?? new UserFolderRepository(_context);

        public IBannerRepository Banners =>
            _bannerRepository = _bannerRepository ?? new BannerRepository(_context);

        public IMessageRepository Messages =>
            _messageRepository = _messageRepository ?? new MessageRepository(_context);

        public IContactInfoRepository ContactInfos =>
        _contactInfoRepository = _contactInfoRepository ?? new ContactInfoRepository(_context);
        
        public ISettingsRepository Settings =>
            _settingsRepository = _settingsRepository ?? new SettingsRepository(_context);
        
        public IWeeklyInfoRepository WeeklyInfos =>
            _weeklyInfoRepository = _weeklyInfoRepository ?? new WeeklyInfoRepository(_context);

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}