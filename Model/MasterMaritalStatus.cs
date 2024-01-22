using System.ComponentModel.DataAnnotations;

namespace management_candidates.Model
{
    public class MasterMaritalStatus : BaseModel
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public int? Sequence { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
    }
}
