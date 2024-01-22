using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace management_candidates.Model
{
    public class Opportunity : BaseModel
    {
        [StringLength(20)]
        public string? Code { get; set; }
        [StringLength(20)]
        public string? Reference { get; set; }
        public DateTime? LastModified { get; set; }
        public string? Name { get; set; }
        [StringLength(20)]
        public string? Status { get; set; }
        public string? PriorityCode { get; set; }
        [ForeignKey("PriorityCode")]
        public MasterPriority? Priority { get; set; }
        public string? PicName { get; set; }
        public string? PicEmail { get; set; }
        public string? PicPhone { get; set; }
        public string? ClientCode { get; set; }
        [ForeignKey("ClientCode")]
        public Client? Client { get; set; }
        public uint? SalesId { get; set; }
        [ForeignKey("SalesId")]
        public Sales? Sales { get; set; }
        public string? Description { get; set; }
        public bool? PsaApproval { get; set; }
        public ICollection<Resource> Resources { get; set; }
    }
}
