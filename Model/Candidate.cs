using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace management_candidates.Model
{
    public class Candidate : BaseModel
    {
        [StringLength(50)]
        public string? FirstName { get; set; }
        [StringLength(50)]
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        [StringLength(50)]
        public string? PlaceOfBirth { get; set; }
        [StringLength(16)]
        public string? IdentifyNumber { get; set; }
        public string? LevelCode { get; set; }
        [ForeignKey("LevelCode")]
        public MasterLevel? MasterLevel { get; set; }
        public string? PositionCode { get; set; }
        [ForeignKey("PositionCode")]
        public MasterPosition? MasterPosition { get; set; }
        public string? MaritalStatusCode { get; set; }
        [ForeignKey("MaritalStatusCode")]
        public MasterMaritalStatus? MasterMaritalStatus { get; set; }
        public string? ReligionCode { get; set; }
        [ForeignKey("ReligionCode")]
        public MasterReligion? MasterReligion { get; set; }
        [StringLength(50)]
        public string? Email {  get; set; }
        [StringLength(50)]
        public string? OfficeEmail { get; set; }
        [StringLength(20)]
        public string? MobileNumber { get; set; }
        [StringLength(150)]
        public string? PhotoProfile { get; set; }
        [StringLength(50)]
        public string? Resume { get; set; }
        public uint? TotalExperience { get; set; }
        [StringLength(150)]
        public string? LinkedinUrl { get; set; }
        [StringLength(20)]
        public string? LastSalary { get; set; }
        [StringLength(20)]
        public string? ExpectationSalary { get; set; }
        [StringLength(50)]
        public string? Availability { get; set; }
        public string? SourceCode { get; set; }
        [ForeignKey("SourceCode")]
        public MasterSource? MasterSource { get; set; }
        public string? WorkTypeCode { get; set; }
        [ForeignKey("WorkTypeCode")]
        public MasterWorkType? MasterWorkType { get; set; }
        public uint? RecruiterId { get; set; }
        [StringLength(50)]
        public string? CareerGoals { get; set; }
        [StringLength(200)]
        public string? Address { get; set; }
        public string? Summary { get; set; }
        public string? RecruiterSummary { get; set; }
        public string? ProcessTypeCode { get; set; }
        [ForeignKey("ProcessTypeCode")]
        public MasterProcessType? MasterProcessType { get; set; }
        public JsonElement? Works { get; set; }
        public JsonElement? Educations { get; set; }
        public JsonElement? Skills { get; set; }
        public JsonElement? Projects { get; set; }
        public JsonElement? Certifications { get; set; }
        public ICollection<Application> Applications { get; set; }
    }
}
