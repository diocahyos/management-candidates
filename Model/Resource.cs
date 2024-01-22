using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace management_candidates.Model
{
    public class Resource : BaseModel
    {
        [StringLength(20)]
        public string? OpportunityCode { get; set; }
        [ForeignKey("OpportunityCode")]
        public Opportunity? Opportunity { get; set; }
        public DateTime? LastModified { get; set; }
        [StringLength(20)]
        public string? Code { get; set; }
        public uint? Ctc {  get; set; }
        public Int16? Quantity { get; set; }
        [StringLength(20)]
        public string? Level { get; set; }
        [StringLength(50)]
        public string? Position { get; set; }
        public string? Requirement { get; set; }
        public int? Duration { get; set; }
        public ICollection<Application> Applications { get; set; }
    }
}
