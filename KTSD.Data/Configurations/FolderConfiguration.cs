using System;
using KTSD.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KTSD.Data.Configurations
{
    public class FolderConfiguration : IEntityTypeConfiguration<Folder>
    {
        public void Configure(EntityTypeBuilder<Folder> builder)
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
                .Property(m => m.OrderIndex);


            builder
                .Property(m => m.CreatedAt)
                .HasDefaultValue(DateTime.Now);

            builder
                .Property(m => m.UpdatedAt);

            builder.Property(m => m.CreatedBy);

            builder.Property(m => m.UpdatedBy);

            builder
                .ToTable("Folders");
        }
    }
}