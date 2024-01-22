using management_candidates.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace management_candidates.DataContext.Configurations
{
    public class ApplicationHistoryConfiguration : IEntityTypeConfiguration<ApplicationHistory>
    {
        public void Configure(EntityTypeBuilder<ApplicationHistory> builder)
        {
            // Table Name
            builder.ToTable("application_histories");

            // Set PrimaryKey
            builder.HasKey(x => x.Id);

            builder
                .HasOne(s => s.Application)
                .WithMany(t => t.ApplicationHistories)
                .HasForeignKey(s => s.ApplicationId)
                .HasPrincipalKey(s => s.Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
