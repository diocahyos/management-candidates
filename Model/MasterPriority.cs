using System.ComponentModel.DataAnnotations;

namespace management_candidates.Model
{
    public class MasterPriority : BaseModel
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public int? Sequence { get; set; }
        public ICollection<Opportunity> Opportunities { get; set; }
    }
}
