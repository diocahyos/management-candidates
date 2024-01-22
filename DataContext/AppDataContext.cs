using management_candidates.DataContext.Configurations;
using management_candidates.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace management_candidates.DataContext
{
    public class AppDataContext : DbContext
    {
        protected readonly IConfiguration _configuration;
        public AppDataContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        static AppDataContext()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<ApplicationHistory> ApplicationHistories { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<MasterLevel> MasterLevels { get; set; }
        public DbSet<MasterMaritalStatus> MasterMaritalStatuses { get; set; }
        public DbSet<MasterPosition> MasterPositions { get; set; }
        public DbSet<MasterPriority> MasterPriorities { get; set; }
        public DbSet<MasterProcessType> MasterPrcoessTypes { get; set; }
        public DbSet<MasterReligion> MasterReligions { get; set; }
        public DbSet<MasterSource> MasterSources { get; set; }
        public DbSet<MasterStatus> MasterStatuses { get; set; }
        public DbSet<MasterWorkType> MasterWorkTypes { get; set; }
        public DbSet<Opportunity> Opportunities { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
            builder.UseLoggerFactory(loggerFactory)
                .UseNpgsql(_configuration.GetConnectionString("postgresdb"));
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ApplicationConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationHistoryConfiguration());
            modelBuilder.ApplyConfiguration(new CandidateConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new MasterLevelConfiguration());
            modelBuilder.ApplyConfiguration(new MasterMaritalStatusConfiguration());
            modelBuilder.ApplyConfiguration(new MasterPositionConfiguration());
            modelBuilder.ApplyConfiguration(new MasterPriorityConfiguration());
            modelBuilder.ApplyConfiguration(new MasterProcessTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MasterReligionConfiguration());
            modelBuilder.ApplyConfiguration(new MasterSourceConfiguration());
            modelBuilder.ApplyConfiguration(new MasterStatusConfiguration());
            modelBuilder.ApplyConfiguration(new MasterWorkTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OpportunityConfiguration());
            modelBuilder.ApplyConfiguration(new ResourceConfiguration());
            modelBuilder.ApplyConfiguration(new SalesConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
