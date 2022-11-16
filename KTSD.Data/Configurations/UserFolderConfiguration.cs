using KTSD.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KTSD.Data.Configurations
{
    public class UserFolderConfiguration: IEntityTypeConfiguration<UserFolder>
    {
        public void Configure(EntityTypeBuilder<UserFolder> builder)
        {
            builder.HasKey(uf => new {uf.UserId, uf.FolderId});
            
            builder.HasOne(uf => uf.User)
                .WithMany(u => u.UserFolders)
                .HasForeignKey(bc => bc.UserId); 
            
            builder.HasOne(uf => uf.Folder)
                .WithMany(f => f.UserFolders)
                .HasForeignKey(uf => uf.FolderId);  
            
            builder
                .ToTable("UserFolders");
        }
    }
}