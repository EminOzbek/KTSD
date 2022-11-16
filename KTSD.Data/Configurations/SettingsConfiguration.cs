using System;
using KTSD.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KTSD.Data.Configurations
{
    public class SettingsConfiguration: IEntityTypeConfiguration<Settings>
    {
        public void Configure(EntityTypeBuilder<Settings> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(m => m.Area1)
                .IsRequired();
            
            
            builder
                .Property(m => m.Area2)
                .IsRequired();
            
            
            builder
                .Property(m => m.Area3)
                .IsRequired();
            
            
            builder
                .Property(m => m.Area4)
                .IsRequired();
            
            builder
                .Property(m => m.CreatedAt)
                .HasDefaultValue(DateTime.Now);
            
            builder
                .Property(m => m.LangCode);

            builder
                .Property(m => m.UpdatedAt);

            builder.Property(m => m.CreatedBy);

            builder.Property(m => m.UpdatedBy);

            builder
                .ToTable("Settings");
        }
    }
}