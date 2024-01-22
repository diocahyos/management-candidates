using management_candidates.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace management_candidates.DataContext.Configurations
{
    public class MasterProcessTypeConfiguration : IEntityTypeConfiguration<MasterProcessType>
    {
        public void Configure(EntityTypeBuilder<MasterProcessType> builder)
        {
            // Table Name
            builder.ToTable("master_process_types");

            // Set PrimaryKey
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Code).IsUnique();
            builder.HasIndex(x => x.Name).IsUnique();
        }
    }
}
