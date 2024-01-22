using management_candidates.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace management_candidates.DataContext.Configurations
{
    public class CandidateConfiguration : IEntityTypeConfiguration<Candidate>
    {
        public void Configure (EntityTypeBuilder<Candidate> builder)
        {
            // Table Name
            builder.ToTable("candidates");

            // Set PrimaryKey
            builder.HasKey(x => x.Id);

            // Set Index
            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x => x.OfficeEmail).IsUnique();

            builder
                .HasOne(s => s.MasterLevel)
                .WithMany(t => t.Candidates)
                .HasForeignKey(s => s.LevelCode)
                .HasPrincipalKey(s => s.Code)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(s => s.MasterPosition)
                .WithMany(t => t.Candidates)
                .HasForeignKey(s => s.PositionCode)
                .HasPrincipalKey(s => s.Code)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(s => s.MasterMaritalStatus)
                .WithMany(t => t.Candidates)
                .HasForeignKey(s => s.MaritalStatusCode)
                .HasPrincipalKey(s => s.Code)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(s => s.MasterReligion)
                .WithMany(t => t.Candidates)
                .HasForeignKey(s => s.ReligionCode)
                .HasPrincipalKey(s => s.Code)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(s => s.MasterSource)
                .WithMany(t => t.Candidates)
                .HasForeignKey(s => s.SourceCode)
                .HasPrincipalKey(s => s.Code)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(s => s.MasterWorkType)
                .WithMany(t => t.Candidates)
                .HasForeignKey(s => s.WorkTypeCode)
                .HasPrincipalKey(s => s.Code)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(s => s.MasterProcessType)
                .WithMany(t => t.Candidates)
                .HasForeignKey(s => s.ProcessTypeCode)
                .HasPrincipalKey(s => s.Code)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
