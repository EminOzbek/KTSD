using System;
using KTSD.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KTSD.Data.Configurations
{
    public class BannerConfiguration: IEntityTypeConfiguration<Banner>
    {
        public void Configure(EntityTypeBuilder<Banner> builder)
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
                .Property(m => m.Description);
            
            builder
                .Property(m => m.Path);

            builder
                .Property(m => m.ButtonText);
            
            builder
                .Property(m => m.ButtonLink);
            builder
                .Property(m => m.LangCode);
            
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
                .ToTable("Banners");
        }
    }
}