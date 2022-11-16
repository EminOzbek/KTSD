using KTSD.Core.Models;
using KTSD.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace KTSD.Data
{
    public class KTSDDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<UserFile> UserFiles { get; set; }
        public DbSet<Folder> Folder { get; set; }
        public DbSet<WorkGroup> WorkGroups { get; set; }
        public DbSet<UserWorkGroup> UserWorkGroups { get; set; }
        public DbSet<NavMenu> NavMenus { get; set; }

        public KTSDDbContext(DbContextOptions<KTSDDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new PageConfiguration());
            modelBuilder.ApplyConfiguration(new MenuConfiguration());
            modelBuilder.ApplyConfiguration(new AnnouncementConfiguration());
            modelBuilder.ApplyConfiguration(new FileConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new WorkGroupConfiguration());
            modelBuilder.ApplyConfiguration(new EventsConfiguration());
            modelBuilder.ApplyConfiguration(new MemberConfiguration());
            modelBuilder.ApplyConfiguration(new UserFileConfiguration());
            modelBuilder.ApplyConfiguration(new UserFolderConfiguration());
            modelBuilder.ApplyConfiguration(new BannerConfiguration());
            modelBuilder.ApplyConfiguration(new MessageConfiguration());
            modelBuilder.ApplyConfiguration(new ContactInfoConfiguration());
            modelBuilder.ApplyConfiguration(new SettingsConfiguration());
            modelBuilder.ApplyConfiguration(new WeeklyInfoConfiguration());
            modelBuilder.ApplyConfiguration(new UserWorkGroupConfiguration());
        }
    }
}