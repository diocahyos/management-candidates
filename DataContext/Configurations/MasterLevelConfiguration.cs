using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using management_candidates.Model;

namespace management_candidates.DataContext.Configurations
{
    public class MasterLevelConfiguration : IEntityTypeConfiguration<MasterLevel>
    {
        public void Configure(EntityTypeBuilder<MasterLevel> builder)
        {
            // Table Name
            builder.ToTable("master_levels");

            // Set PrimaryKey
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Code).IsUnique();
            builder.HasIndex(x => x.Name).IsUnique();
        }
    }
}
