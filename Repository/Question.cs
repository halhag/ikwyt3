using System.Collections.Generic;

namespace Repository
{
    public class Question
    {
        public string Text { get; set; }
        public string AdditionalText { get; set; }
        public List<Alternative> Alternatives { get; set; }
        public int Order { get; set; }
    }
}
