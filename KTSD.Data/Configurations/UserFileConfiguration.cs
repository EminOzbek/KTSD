using KTSD.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KTSD.Data.Configurations
{
    public class UserFileConfiguration : IEntityTypeConfiguration<UserFile>
    {
        public void Configure(EntityTypeBuilder<UserFile> builder)
        {
            builder.HasKey(uf => new {uf.UserId, uf.FileId});
            
            builder.HasOne(uf => uf.User)
                .WithMany(u => u.UserFiles)
                .HasForeignKey(bc => bc.UserId); 
            
            builder.HasOne(uf => uf.File)
                .WithMany(f => f.UserFiles)
                .HasForeignKey(uf => uf.FileId);  
            
            builder
                .ToTable("UserFiles");
        }
    }
}