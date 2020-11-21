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
            
            // Behavioral economics
            metaQuizzes.Add(GetDifficultChoices());
            metaQuizzes.Add(GetAltruism());
            metaQuizzes.Add(GetRelativeValues());
            metaQuizzes.Add(GetRewardsAndBonuses());
            metaQuizzes.Add(GetRevenge());
            metaQuizzes.Add(GetRewardsPunishmentHappiness());
            metaQuizzes.Add(GetSocialNorms());
            metaQuizzes.Add(GetOrderingFoodBeveragesII());
            metaQuizzes.Add(GetOrderingFoodBeverages());

            // Biology
            metaQuizzes.Add(GetBody());
            metaQuizzes.Add(GetBrain());
            metaQuizzes.Add(GetMeditationExercise());
            metaQuizzes.Add(GetTime());

            return metaQuizzes;
        }

        public MetaQuiz GetSocialNorms()
        {
            var quiz = new MetaQuiz
            {
                Category = "Behavioral Economics",
                Description = "Does thinking about money make you more individualistic?  Does thinking about money make you less helpful?  And other questions based on Dan Ariely's books.",
                ExternalReference = "Social Norms",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 9,
                NumTimesPlayed = 0,
                Title = "Social Norms",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetDifficultChoices()
        {
            var quiz = new MetaQuiz
            {
                Category = "Behavioral Economics",
                Description = "Will fewer choices lead to better decisions?  Do random numbers influence our bidding price?  Does something offered for free confuse our optimal decision-making?  And other questions based on Dan Ariely's books.",
                ExternalReference = "Difficult Choices",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 10,
                NumTimesPlayed = 0,
                Title = "Difficult Choices",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetAltruism()
        {
            var quiz = new MetaQuiz
            {
                Category = "Behavioral Economics",
                Description = "Questions from studies on the Dictator and Ultimatum games.",
                ExternalReference = "Altruism",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 9,
                NumTimesPlayed = 0,
                Title = "Altruism",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetRelativeValues()
        {
            var quiz = new MetaQuiz
            {
                Category = "Behavioral Economics",
                Description = "Do people overvalue what they have built themselves?  And other questions based on Dan Ariely's books.",
                ExternalReference = "Relative Values",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 8,
                NumTimesPlayed = 0,
                Title = "Relative Values",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetRewardsAndBonuses()
        {
            var quiz = new MetaQuiz
            {
                Category = "Behavioral Economics",
                Description = "Do bonuses lead to better performances?  What was the effect of performing in public?  And other questions based on Dan Ariely's books.",
                ExternalReference = "Revards Bonuses",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 8,
                NumTimesPlayed = 0,
                Title = "Rewards & Bonuses",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetRevenge()
        {
            var quiz = new MetaQuiz
            {
                Category = "Behavioral Economics",
                Description = "Would people take a personal loss to exact revenge?  Questions about revenge from the Ultimate game and other related studies.",
                ExternalReference = "Revenge",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 12,
                NumTimesPlayed = 0,
                Title = "Revenge",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetRewardsPunishmentHappiness()
        {
            var quiz = new MetaQuiz
            {
                Category = "Behavioral Economics",
                Description = "Do you work harder if you work for money?",
                ExternalReference = "Rewards Punishment Happiness",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 9,
                NumTimesPlayed = 0,
                Title = "Rewards, Punishment & Happiness",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetOrderingFoodBeveragesII()
        {
            var quiz = new MetaQuiz
            {
                Category = "Behavioral Economics",
                Description = "Do you like stale popcorn?  Do you eat more if you are served larger portions?  And other questions on our eating and drinking habits.",
                ExternalReference = "Ordering Food Beverages II",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 8,
                NumTimesPlayed = 0,
                Title = "Ordering Food & Beverages II",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetOrderingFoodBeverages()
        {
            var quiz = new MetaQuiz
            {
                Category = "Behavioral Economics",
                Description = "Would a nicer environment make you pay more for a coffee?  Does information taint your tasting experiences?  Does ordering beer in public vs. in private make a difference?  And other questions on our eating and drinking habits.",
                ExternalReference = "Ordering Food Beverages",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 8,
                NumTimesPlayed = 0,
                Title = "Ordering Food & Beverages",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetBody()
        {
            var quiz = new MetaQuiz
            {
                Category = "Biology",
                Description = "Could drinking blood make you younger?  Is it possible to increase body temperature through the will of the mind?",
                ExternalReference = "Body",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 9,
                NumTimesPlayed = 0,
                Title = "The Body",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetBrain()
        {
            var quiz = new MetaQuiz
            {
                Category = "Biology",
                Description = "Can you tickle yourself?  And other questions from neuroscience.",
                ExternalReference = "Brain",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 8,
                NumTimesPlayed = 0,
                Title = "The Brain",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetMeditationExercise()
        {
            var quiz = new MetaQuiz
            {
                Category = "Biology",
                Description = "Does meditation work?  And other questions from neuroscience.",
                ExternalReference = "Meditation Exercise",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 9,
                NumTimesPlayed = 0,
                Title = "Meditation & Exercise",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetTime()
        {
            var quiz = new MetaQuiz
            {
                Category = "Biology",
                Description = "Does time go faster when you have fun?  Does it go slower when you are scared?  And other questions from neuroscience.",
                ExternalReference = "Time",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 13,
                NumTimesPlayed = 0,
                Title = "Time",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }
    }
}
