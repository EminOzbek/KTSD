using KTSD.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KTSD.Data.Configurations
{
    public class WorkGroupConfiguration : IEntityTypeConfiguration<WorkGroup>
    {
        public void Configure(EntityTypeBuilder<WorkGroup> builder)
        {
            builder
                .HasKey(r => r.Id);

            builder
                .Property(m => m.Id);

            builder
                .Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .ToTable("WorkGroups");
        }
    }
}