using management_candidates.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace management_candidates.DataContext.Configurations
{
    public class SalesConfiguration : IEntityTypeConfiguration<Sales>
    {
        public void Configure(EntityTypeBuilder<Sales> builder)
        {
            builder.ToTable("sales");

            builder.HasKey(s => s.Id);

            builder.HasIndex(x => x.Email).IsUnique();
        }
    }
}
