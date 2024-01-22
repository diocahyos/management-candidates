namespace management_candidates.Model
{
    public class MasterProcessType : BaseModel
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
    }
}
