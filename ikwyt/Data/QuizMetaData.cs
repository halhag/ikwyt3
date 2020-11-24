using System;

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
        public string Description { get; set; }
        public DateTime LastPlayed { get; set; }
        public int NumTimesPlayed { get; set; }
        public double UnderlyingDifficulty { get; set; }
    }
}
