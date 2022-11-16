using System;
using KTSD.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KTSD.Data.Configurations
{
    public class FileConfiguration: IEntityTypeConfiguration<File>
    {
        public void Configure(EntityTypeBuilder<File> builder)
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
                .Property(m => m.Size);
            
            builder
                .HasOne(m => m.Folder)
                .WithMany(a => a.Files)
                .HasForeignKey(m => m.FolderId);
            
            builder
                .Property(m => m.CreatedAt)
                // .HasDefaultValue(DateTime.Now);
                .HasDefaultValueSql("getDate()");

            builder
                .Property(m => m.UpdatedAt);
            
            builder.Property(m => m.CreatedBy);

            builder.Property(m => m.UpdatedBy);
            
            builder
                .ToTable("Files");
        }
    }
}