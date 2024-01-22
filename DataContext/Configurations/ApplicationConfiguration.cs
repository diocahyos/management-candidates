using management_candidates.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System;

namespace management_candidates.DataContext.Configurations
{
    public class ApplicationConfiguration : IEntityTypeConfiguration<Application>
    {
        public void Configure(EntityTypeBuilder<Application> builder)
        {
            // Table Name
            builder.ToTable("applications");

            // Set PrimaryKey
            builder.HasKey(x => x.Id);

            builder
                .HasOne(s => s.Resource)
                .WithMany(t => t.Applications)
                .HasForeignKey(s => s.ResourceCode)
                .HasPrincipalKey(s => s.Code)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(s => s.MasterStatus)
                .WithMany(t => t.Applications)
                .HasForeignKey(s => s.StatusCode)
                .HasPrincipalKey(s => s.Code)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(s => s.Candidate)
                .WithMany(t => t.Applications)
                .HasForeignKey(s => s.CandidateId)
                .HasPrincipalKey(s => s.Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
