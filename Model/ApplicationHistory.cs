using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace management_candidates.Model
{
    [Table("application_histories")]
    public class ApplicationHistory : BaseModel
    {
        public uint? ApplicationId { get; set; }
        [ForeignKey("ApplicationId")]
        public Application? Application { get; set; }
        public string? ApplicationStatusName {  get; set; }
        public JsonElement? Value { get; set;}
        
    }
}
