using management_candidates.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace management_candidates.DataContext.Configurations
{
    public class MasterWorkTypeConfiguration : IEntityTypeConfiguration<MasterWorkType>
    {
        public void Configure(EntityTypeBuilder<MasterWorkType> builder)
        {
            // Table Name
            builder.ToTable("master_work_types");

            // Set PrimaryKey
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Code).IsUnique();
            builder.HasIndex(x => x.Name).IsUnique();
        }
    }
}
