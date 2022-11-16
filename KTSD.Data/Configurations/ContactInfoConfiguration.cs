using System;
using KTSD.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KTSD.Data.Configurations
{
    public class ContactInfoConfiguration: IEntityTypeConfiguration<ContactInfo>
    {
        public void Configure(EntityTypeBuilder<ContactInfo> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();
            
            builder
                .Property(m => m.Phone);
            
            builder
                .Property(m => m.Fax);
            
            builder
                .Property(m => m.Email);
            
            builder
                .Property(m => m.Address);
            
            builder
                .Property(m => m.FacebookLink);
            
            builder
                .Property(m => m.LinkedinLink);
            
            builder
                .Property(m => m.InstagramLink);
            
            builder
                .Property(m => m.TwitterLink);
            
            builder
                .Property(m => m.TiktokLink);

            builder
                .Property(m => m.CreatedAt)
                .HasDefaultValue(DateTime.Now);

            builder
                .Property(m => m.UpdatedAt);

            builder.Property(m => m.CreatedBy);

            builder.Property(m => m.UpdatedBy);

            builder
                .ToTable("ContactInfos");
        }
    }
}