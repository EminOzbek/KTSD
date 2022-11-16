using System;
using KTSD.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KTSD.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(m => m.Name)
                .IsRequired();

            builder
                .Property(m => m.LastName)
                .IsRequired();

            builder
                .Property(m => m.Email)
                .IsRequired();


            builder
                .Property(m => m.Password)
                .IsRequired();

            builder
                .Property(m => m.CreatedAt)
                .HasDefaultValue(DateTime.Now);

            builder
                .Property(m => m.UpdatedAt);

            builder
                .Property(m => m.LastLoginTime);

            builder
                .Property(m => m.FirstLogin)
                .HasDefaultValue(false);

            builder
                .HasOne(m => m.Role)
                .WithMany(a => a.Users)
                .HasForeignKey(m => m.RoleId);
            
            builder
                .HasOne(m => m.Member)
                .WithMany(a => a.Users)
                .HasForeignKey(m => m.MemberId);

            builder
                .ToTable("Users");
        }
    }
}