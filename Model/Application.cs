using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace management_candidates.Model
{
    public class Application : BaseModel
    {
        public uint? CandidateId { get; set; }
        [ForeignKey("CandidateId")]
        public Candidate? Candidate { get; set; }
        public string? ResourceCode { get; set; }
        [ForeignKey("ResourceCode")]
        public Resource? Resource { get; set; }
        public string? StatusCode { get; set; }
        [ForeignKey("StatusCode")]
        public MasterStatus? MasterStatus { get; set; }
        public ICollection<ApplicationHistory> ApplicationHistories { get; set; }
    }
}
