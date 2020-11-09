using System.Collections.Generic;

namespace Repository
{
    public class Quiz
    {
        public Quiz()
        {
            Questions = new List<Question>();
            References = new List<Reference>();
        }

        public string Id { get; set; }
        public string Category { get; set; }
        public List<Question> Questions { get; set; }
        public string Title { get; set; }
        public List<Reference> References { get; set; }
        public string ReferenceFile { get; set; }
    }
}
