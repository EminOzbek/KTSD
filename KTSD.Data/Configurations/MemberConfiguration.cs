using KTSD.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KTSD.Data.Configurations
{
    public class MemberConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder
                .HasKey(r => r.Id);

            builder
                .Property(m => m.Id);

            builder
                .Property(m => m.Name) 
                .IsRequired();

            builder
                .Property(m => m.Phone)
                .IsRequired();

            builder
                .Property(m => m.Address)
                .IsRequired();

            builder
                .ToTable("Members");
        }
    }
}