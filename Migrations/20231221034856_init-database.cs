using System;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace management_candidates.Migrations
{
    public partial class initdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.Id);
                    table.UniqueConstraint("AK_clients_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "master_levels",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Sequence = table.Column<int>(type: "integer", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true),
                    AccentColor = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_master_levels", x => x.Id);
                    table.UniqueConstraint("AK_master_levels_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "master_marital_statueses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Sequence = table.Column<int>(type: "integer", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_master_marital_statueses", x => x.Id);
                    table.UniqueConstraint("AK_master_marital_statueses_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "master_positions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Sequence = table.Column<int>(type: "integer", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_master_positions", x => x.Id);
                    table.UniqueConstraint("AK_master_positions_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "master_priorities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Sequence = table.Column<int>(type: "integer", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_master_priorities", x => x.Id);
                    table.UniqueConstraint("AK_master_priorities_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "master_process_types",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_master_process_types", x => x.Id);
                    table.UniqueConstraint("AK_master_process_types_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "master_religions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Sequence = table.Column<int>(type: "integer", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_master_religions", x => x.Id);
                    table.UniqueConstraint("AK_master_religions_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "master_sources",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Sequence = table.Column<int>(type: "integer", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_master_sources", x => x.Id);
                    table.UniqueConstraint("AK_master_sources_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "master_statuses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Sequence = table.Column<int>(type: "integer", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true),
                    AccentColor = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_master_statuses", x => x.Id);
                    table.UniqueConstraint("AK_master_statuses_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "master_work_types",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Sequence = table.Column<int>(type: "integer", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_master_work_types", x => x.Id);
                    table.UniqueConstraint("AK_master_work_types_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "sales",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "opportunities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Reference = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    PriorityCode = table.Column<string>(type: "text", nullable: true),
                    PicName = table.Column<string>(type: "text", nullable: true),
                    PicEmail = table.Column<string>(type: "text", nullable: true),
                    PicPhone = table.Column<string>(type: "text", nullable: true),
                    ClientCode = table.Column<string>(type: "text", nullable: true),
                    SalesId = table.Column<long>(type: "bigint", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    PsaApproval = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_opportunities", x => x.Id);
                    table.UniqueConstraint("AK_opportunities_Code", x => x.Code);
                    table.ForeignKey(
                        name: "FK_opportunities_clients_ClientCode",
                        column: x => x.ClientCode,
                        principalTable: "clients",
                        principalColumn: "Code",
                        onUpdate: ReferentialAction.Cascade,
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_opportunities_master_priorities_PriorityCode",
                        column: x => x.PriorityCode,
                        principalTable: "master_priorities",
                        principalColumn: "Code",
                        onUpdate: ReferentialAction.Cascade,
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_opportunities_sales_SalesId",
                        column: x => x.SalesId,
                        principalTable: "sales",
                        principalColumn: "Id", 
                        onUpdate: ReferentialAction.Cascade,
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "candidates",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    PlaceOfBirth = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    IdentifyNumber = table.Column<string>(type: "character varying(16)", maxLength: 16, nullable: true),
                    LevelCode = table.Column<string>(type: "text", nullable: true),
                    PositionCode = table.Column<string>(type: "text", nullable: true),
                    MaritalStatusCode = table.Column<string>(type: "text", nullable: true),
                    ReligionCode = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    OfficeEmail = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    MobileNumber = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    PhotoProfile = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    Resume = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    TotalExperience = table.Column<long>(type: "bigint", nullable: true),
                    LinkedinUrl = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    LastSalary = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    ExpectationSalary = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Availability = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    SourceCode = table.Column<string>(type: "text", nullable: true),
                    WorkTypeCode = table.Column<string>(type: "text", nullable: true),
                    RecruiterId = table.Column<long>(type: "bigint", nullable: true),
                    CareerGoals = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    Summary = table.Column<string>(type: "text", nullable: true),
                    RecruiterSummary = table.Column<string>(type: "text", nullable: true),
                    ProcessTypeCode = table.Column<string>(type: "text", nullable: true),
                    Works = table.Column<JsonElement>(type: "jsonb", nullable: true),
                    Educations = table.Column<JsonElement>(type: "jsonb", nullable: true),
                    Skills = table.Column<JsonElement>(type: "jsonb", nullable: true),
                    Projects = table.Column<JsonElement>(type: "jsonb", nullable: true),
                    Certifications = table.Column<JsonElement>(type: "jsonb", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_candidates_master_levels_LevelCode",
                        column: x => x.LevelCode,
                        principalTable: "master_levels",
                        principalColumn: "Code",
                        onUpdate: ReferentialAction.Cascade,
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_candidates_master_marital_statueses_MaritalStatusCode",
                        column: x => x.MaritalStatusCode,
                        principalTable: "master_marital_statueses",
                        principalColumn: "Code",
                        onUpdate: ReferentialAction.Cascade,
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_candidates_master_positions_PositionCode",
                        column: x => x.PositionCode,
                        principalTable: "master_positions",
                        principalColumn: "Code",
                        onUpdate: ReferentialAction.Cascade,
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_candidates_master_process_types_ProcessTypeCode",
                        column: x => x.ProcessTypeCode,
                        principalTable: "master_process_types",
                        principalColumn: "Code",
                        onUpdate: ReferentialAction.Cascade,
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_candidates_master_religions_ReligionCode",
                        column: x => x.ReligionCode,
                        principalTable: "master_religions",
                        principalColumn: "Code",
                        onUpdate: ReferentialAction.Cascade,
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_candidates_master_sources_SourceCode",
                        column: x => x.SourceCode,
                        principalTable: "master_sources",
                        principalColumn: "Code",
                        onUpdate: ReferentialAction.Cascade,
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_candidates_master_work_types_WorkTypeCode",
                        column: x => x.WorkTypeCode,
                        principalTable: "master_work_types",
                        principalColumn: "Code",
                        onUpdate: ReferentialAction.Cascade,
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "resources",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OpportunityCode = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Code = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Ctc = table.Column<long>(type: "bigint", nullable: true),
                    Quantity = table.Column<short>(type: "smallint", nullable: true),
                    Level = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Position = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Requirement = table.Column<string>(type: "text", nullable: true),
                    Duration = table.Column<int>(type: "integer", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resources", x => x.Id);
                    table.UniqueConstraint("AK_resources_Code", x => x.Code);
                    table.ForeignKey(
                        name: "FK_resources_opportunities_OpportunityCode",
                        column: x => x.OpportunityCode,
                        principalTable: "opportunities",
                        principalColumn: "Code",
                        onUpdate: ReferentialAction.Cascade,
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "applications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CandidateId = table.Column<long>(type: "bigint", nullable: true),
                    ResourceCode = table.Column<string>(type: "character varying(20)", nullable: true),
                    StatusCode = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_applications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_applications_candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "candidates",
                        principalColumn: "Id",
                        onUpdate: ReferentialAction.Cascade,
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_applications_master_statuses_StatusCode",
                        column: x => x.StatusCode,
                        principalTable: "master_statuses",
                        principalColumn: "Code",
                        onUpdate: ReferentialAction.Cascade,
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_applications_resources_ResourceCode",
                        column: x => x.ResourceCode,
                        principalTable: "resources",
                        principalColumn: "Code",
                        onUpdate: ReferentialAction.Cascade,
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "application_histories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: true),
                    ApplicationStatusName = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<JsonElement>(type: "jsonb", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_application_histories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_application_histories_applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "applications",
                        principalColumn: "Id",
                        onUpdate: ReferentialAction.Cascade,
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_application_histories_ApplicationId",
                table: "application_histories",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_applications_CandidateId",
                table: "applications",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_applications_ResourceCode",
                table: "applications",
                column: "ResourceCode");

            migrationBuilder.CreateIndex(
                name: "IX_applications_StatusCode",
                table: "applications",
                column: "StatusCode");

            migrationBuilder.CreateIndex(
                name: "IX_candidates_Email",
                table: "candidates",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_candidates_LevelCode",
                table: "candidates",
                column: "LevelCode");

            migrationBuilder.CreateIndex(
                name: "IX_candidates_MaritalStatusCode",
                table: "candidates",
                column: "MaritalStatusCode");

            migrationBuilder.CreateIndex(
                name: "IX_candidates_OfficeEmail",
                table: "candidates",
                column: "OfficeEmail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_candidates_PositionCode",
                table: "candidates",
                column: "PositionCode");

            migrationBuilder.CreateIndex(
                name: "IX_candidates_ProcessTypeCode",
                table: "candidates",
                column: "ProcessTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_candidates_ReligionCode",
                table: "candidates",
                column: "ReligionCode");

            migrationBuilder.CreateIndex(
                name: "IX_candidates_SourceCode",
                table: "candidates",
                column: "SourceCode");

            migrationBuilder.CreateIndex(
                name: "IX_candidates_UserId",
                table: "candidates",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_candidates_WorkTypeCode",
                table: "candidates",
                column: "WorkTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_clients_Code",
                table: "clients",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_master_levels_Code",
                table: "master_levels",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_master_levels_Name",
                table: "master_levels",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_master_marital_statueses_Code",
                table: "master_marital_statueses",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_master_marital_statueses_Name",
                table: "master_marital_statueses",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_master_positions_Code",
                table: "master_positions",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_master_positions_Name",
                table: "master_positions",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_master_priorities_Code",
                table: "master_priorities",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_master_priorities_Name",
                table: "master_priorities",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_master_process_types_Code",
                table: "master_process_types",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_master_process_types_Name",
                table: "master_process_types",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_master_religions_Code",
                table: "master_religions",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_master_religions_Name",
                table: "master_religions",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_master_sources_Code",
                table: "master_sources",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_master_sources_Name",
                table: "master_sources",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_master_statuses_Code",
                table: "master_statuses",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_master_statuses_Name",
                table: "master_statuses",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_master_work_types_Code",
                table: "master_work_types",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_master_work_types_Name",
                table: "master_work_types",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_opportunities_ClientCode",
                table: "opportunities",
                column: "ClientCode");

            migrationBuilder.CreateIndex(
                name: "IX_opportunities_PriorityCode",
                table: "opportunities",
                column: "PriorityCode");

            migrationBuilder.CreateIndex(
                name: "IX_opportunities_SalesId",
                table: "opportunities",
                column: "SalesId");

            migrationBuilder.CreateIndex(
                name: "IX_resources_Code",
                table: "resources",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_resources_OpportunityCode",
                table: "resources",
                column: "OpportunityCode");

            migrationBuilder.CreateIndex(
                name: "IX_sales_Email",
                table: "sales",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_Email",
                table: "users",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "application_histories");

            migrationBuilder.DropTable(
                name: "applications");

            migrationBuilder.DropTable(
                name: "candidates");

            migrationBuilder.DropTable(
                name: "master_statuses");

            migrationBuilder.DropTable(
                name: "resources");

            migrationBuilder.DropTable(
                name: "master_levels");

            migrationBuilder.DropTable(
                name: "master_marital_statueses");

            migrationBuilder.DropTable(
                name: "master_positions");

            migrationBuilder.DropTable(
                name: "master_process_types");

            migrationBuilder.DropTable(
                name: "master_religions");

            migrationBuilder.DropTable(
                name: "master_sources");

            migrationBuilder.DropTable(
                name: "master_work_types");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "opportunities");

            migrationBuilder.DropTable(
                name: "clients");

            migrationBuilder.DropTable(
                name: "master_priorities");

            migrationBuilder.DropTable(
                name: "sales");
        }
    }
}
