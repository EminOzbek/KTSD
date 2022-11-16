using System;
using KTSD.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KTSD.Data.Configurations
{
    public class AnnouncementConfiguration : IEntityTypeConfiguration<Announcement>
    {
        public void Configure(EntityTypeBuilder<Announcement> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(m => m.Title)
                .IsRequired();

            builder
                .Property(m => m.Content);
            
            builder
                .Property(m => m.Image);
            builder
                .Property(m => m.Thumbnail);
            builder
                .Property(m => m.Description);

            builder
                .Property(m => m.StartDate)
                .IsRequired();
            
            builder
                .Property(m => m.EndDate)
                .IsRequired();

            builder
                .Property(m => m.Status);
            
            builder
                .Property(m => m.LangCode);
            
            builder
                .Property(m => m.CreatedAt)
                .HasDefaultValue(DateTime.Now);

            builder
                .Property(m => m.UpdatedAt);
            
            builder.Property(m => m.CreatedBy);

            builder.Property(m => m.UpdatedBy);
            
            builder
                .ToTable("Announcements");

        }
    }
}