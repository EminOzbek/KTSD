using KTSD.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KTSD.Data.Configurations
{
    public class UserWorkGroupConfiguration: IEntityTypeConfiguration<UserWorkGroup>
    {
        public void Configure(EntityTypeBuilder<UserWorkGroup> builder)
        {
            builder.HasKey(uw => new {uw.UserId, uw.WorkGroupId});
            
            builder.HasOne(uw => uw.User)
                .WithMany(u => u.UserWorkGroups)
                .HasForeignKey(bc => bc.UserId); 
            
            builder.HasOne(uw => uw.WorkGroup)
                .WithMany(f => f.UserWorkGroups)
                .HasForeignKey(uw => uw.WorkGroupId);
            
            builder
                .ToTable("UserWorkGroup");
        }
    }
}