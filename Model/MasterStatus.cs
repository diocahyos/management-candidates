using System.ComponentModel.DataAnnotations;

namespace management_candidates.Model
{
    public class MasterStatus : BaseModel
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public int? Sequence { get; set; }
        public string? Color { get; set; }
        public string? AccentColor { get; set; }
        public ICollection<Application> Applications { get; set; }
    }
}
