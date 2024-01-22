using management_candidates.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace management_candidates.DataContext.Configurations
{
    public class ResourceConfiguration : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.ToTable("resources");

            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Code).IsUnique();

            builder
                .HasOne(s => s.Opportunity)
                .WithMany(t => t.Resources)
                .HasForeignKey(s => s.OpportunityCode)
                .HasPrincipalKey(s => s.Code)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
