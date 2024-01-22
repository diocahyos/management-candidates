﻿using management_candidates.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace management_candidates.DataContext.Configurations
{
    public class MasterStatusConfiguration : IEntityTypeConfiguration<MasterStatus>
    {
        public void Configure(EntityTypeBuilder<MasterStatus> builder)
        {
            // Table Name
            builder.ToTable("master_statuses");

            // Set PrimaryKey
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Code).IsUnique();
            builder.HasIndex(x => x.Name).IsUnique();
        }
    }
}
