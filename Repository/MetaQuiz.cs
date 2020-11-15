﻿using System;
using System.Collections.Generic;

namespace Repository
{
    public class MetaQuiz
    {
        public MetaQuiz()
        {
            SimilarQuizzes = new List<MetaRecommendation>();
        }

        public string ExternalReference { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int YearCreated { get; set; }
        public int NumQuestions { get; set; }
        public int NumTimesPlayed { get; set; }
        public int TotalScore { get; set; }
        public DateTime LastPlayed { get; set; }
        public List<MetaRecommendation> SimilarQuizzes { get; set; }
    }
}
