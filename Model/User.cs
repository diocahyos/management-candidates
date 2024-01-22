using System.ComponentModel.DataAnnotations;

namespace management_candidates.Model
{
    public class User : BaseModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}
