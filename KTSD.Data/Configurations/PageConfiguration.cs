using System;
using KTSD.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KTSD.Data.Configurations
{
    public class PageConfiguration : IEntityTypeConfiguration<Page>
    {
        public void Configure(EntityTypeBuilder<Page> builder)
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
                .Property(m => m.Image);

            builder.Property(m => m.Keywords);

            builder.Property(m => m.Slug);

            builder.Property(m => m.Content);

            builder.Property(m => m.Status);
            
            builder
                .Property(m => m.LangCode);

            // builder.HasOne(m => m.Menu)
            //     .WithMany(a => a.Pages)
            //     .HasForeignKey(m => m.MenuId);

            builder
                .Property(m => m.CreatedAt)
                .HasDefaultValue(DateTime.Now);

            builder
                .Property(m => m.UpdatedAt);

            builder.Property(m => m.CreatedBy);

            builder.Property(m => m.UpdatedBy);


            builder
                .ToTable("Pages");


        }
    }
}