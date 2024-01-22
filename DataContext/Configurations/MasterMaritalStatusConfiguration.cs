using management_candidates.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace management_candidates.DataContext.Configurations
{
    public class MasterMaritalStatusConfiguration : IEntityTypeConfiguration<MasterMaritalStatus>
    {
        public void Configure(EntityTypeBuilder<MasterMaritalStatus> builder)
        {
            // Table Name
            builder.ToTable("master_marital_statueses");

            // Set PrimaryKey
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Code).IsUnique();
            builder.HasIndex(x => x.Name).IsUnique();
        }
    }
}
