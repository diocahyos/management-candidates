using System.ComponentModel.DataAnnotations;

namespace management_candidates.Model
{
    public class Client : BaseModel
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public ICollection<Opportunity> Opportunities { get; set; }
    }
}
