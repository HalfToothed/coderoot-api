using static coderoot.Constants.Constant;

namespace coderoot.Entities
{
    public class Problem
    {
        public int Id { get; set; }
        public int ProblemId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int Acceptance { get; set; }
        public Difficulty Difficulty { get; set; }
        public Status Status { get; set; }
        public int TopicId { get; set; }
        public Topic? Topic { get; set; }

    }
}
