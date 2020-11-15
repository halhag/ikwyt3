using Repository;
using System;
using System.Collections.Generic;

namespace Meta
{
    public class MetaQuizzes
    {
        public List<MetaQuiz> GetAll()
        {
            var metaQuizzes = new List<MetaQuiz>();
            
            metaQuizzes.Add(GetSocialNorms());
            metaQuizzes.Add(GetDifficultChoices());

            return metaQuizzes;
        }

        public MetaQuiz GetSocialNorms()
        {
            var metaRecommendations = new List<MetaRecommendation>();
            metaRecommendations.Add(new MetaRecommendation
            {
                ExternalReference = "Difficult Choices",
                Reason = "Based on books by Dan Ariely",
                Title = "Difficult Choices"
            });
            metaRecommendations.Add(new MetaRecommendation
            {
                ExternalReference = "Revards Bonuses",
                Reason = "Based on books by Dan Ariely",
                Title = "Rewards & Bonuses"
            });
            metaRecommendations.Add(new MetaRecommendation
            {
                ExternalReference = "Assessment",
                Reason = "Based on books by Dan Ariely",
                Title = "Assessment"
            });
            var socialNorms = new MetaQuiz
            {
                Category = "Behavioral Economics",
                Description = "This was one of the first quizzes made for this site.  It was mostly taken directly from the books by behavioral economist Dan Ariely where he describes his and other's experiments in such a detailed and easy to read fashion that creating questions was easy.  If you are surprised by the correct answers I would suggest you read his book <i>Predictably Irrational</i> from 2008.",
                ExternalReference = "Social Norms",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 9,
                NumTimesPlayed = 0,
                SimilarQuizzes = metaRecommendations,
                Title = "Social Norms",
                TotalScore = 0,
                YearCreated = 2012
            };
            return socialNorms;
        }

        public MetaQuiz GetDifficultChoices()
        {
            var metaRecommendations = new List<MetaRecommendation>();
            metaRecommendations.Add(new MetaRecommendation
            {
                ExternalReference = "Social Norms",
                Reason = "Based on books by Dan Ariely",
                Title = "Social Norms"
            });
            metaRecommendations.Add(new MetaRecommendation
            {
                ExternalReference = "Revards Bonuses",
                Reason = "Based on books by Dan Ariely",
                Title = "Rewards & Bonuses"
            });
            metaRecommendations.Add(new MetaRecommendation
            {
                ExternalReference = "Assessment",
                Reason = "Based on books by Dan Ariely",
                Title = "Assessment"
            });
            var difficultChoices = new MetaQuiz
            {
                Category = "Behavioral Economics",
                Description = "Another quiz made based upon the books by Israeli behavioral economist Dan Ariely.  I recommend reading one of his books for the unusual detailed descriptions of how his experiments are run.",
                ExternalReference = "Difficult Choices",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 10,
                NumTimesPlayed = 0,
                SimilarQuizzes = metaRecommendations,
                Title = "Difficult Choices",
                TotalScore = 0,
                YearCreated = 2012
            };
            return difficultChoices;
        }
    }
}
