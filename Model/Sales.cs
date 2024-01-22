using System.ComponentModel.DataAnnotations;

namespace management_candidates.Model
{
    public class Sales : BaseModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public ICollection<Opportunity> Opportunities { get; set; }
    }
}
