namespace IKWYT.Data
{
    public class QuizMetaData
    {
        public string ExternalReference { get; set; }
        public string Title { get; set; }
        public int NumQuestions { get; set; }
        public string Difficulty { get; set; }
        public string Category { get; set; }
        public int DifficultyValue { get; set; }
    }
}
