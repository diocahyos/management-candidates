using management_candidates.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace management_candidates.DataContext.Configurations
{
    public class OpportunityConfiguration : IEntityTypeConfiguration<Opportunity>
    {
        public void Configure(EntityTypeBuilder<Opportunity> builder)
        {
            // Table Name
            builder.ToTable("opportunities");

            // Set PrimaryKey
            builder.HasKey(x => x.Id);

            builder
                .HasOne(s => s.Priority)
                .WithMany(t => t.Opportunities)
                .HasForeignKey(s => s.PriorityCode)
                .HasPrincipalKey(s => s.Code)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(s => s.Client)
                .WithMany(t => t.Opportunities)
                .HasForeignKey(s => s.ClientCode)
                .HasPrincipalKey(s => s.Code)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(s => s.Sales)
                .WithMany(t => t.Opportunities)
                .HasForeignKey(s => s.SalesId)
                .HasPrincipalKey(s => s.Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
