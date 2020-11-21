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

            // Demography
            metaQuizzes.Add(GetComparingCountries());
            metaQuizzes.Add(GetCorruption());
            metaQuizzes.Add(GetRandomDemographics());

            // Sociology
            metaQuizzes.Add(GetAmericanSocialStudies());
            metaQuizzes.Add(GetConsumerism());
            metaQuizzes.Add(GetFuture());
            metaQuizzes.Add(GetSchoolLifeII());
            metaQuizzes.Add(GetUSTrendsII());
            metaQuizzes.Add(GetUSTrends());

            // Experimental philosophy
            metaQuizzes.Add(GetPainTortureDeath());
            metaQuizzes.Add(GetToughMoralChoices());

            // Mix
            metaQuizzes.Add(GetNewResearch2012());
            metaQuizzes.Add(GetNewResearch2013());
            metaQuizzes.Add(GetPainTortureDeath());
            metaQuizzes.Add(GetToughMoralChoices());

            return metaQuizzes;
        }

        #region Behavioral Economics

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

        #endregion
        #region Biology

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

        #endregion
        #region Demography

        public MetaQuiz GetComparingCountries()
        {
            var quiz = new MetaQuiz
            {
                Category = "Demography",
                Description = "In which country do they trust each other the most?  Which country have most obese people?  Teenage pregnancies?",
                ExternalReference = "Comparing countries",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 15,
                NumTimesPlayed = 0,
                Title = "Comparing countries",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetCorruption()
        {
            var quiz = new MetaQuiz
            {
                Category = "Demography",
                Description = "Transparency International annually ranks countries by their perceived levels of corruption, as determined by expert assessments and opinion surveys.  The index is called the Corruption Perceptions Index and defines corruption as the misuse of public power for private benefit.  In the 2011 index, 183 countries are ranked from 0 (everything is corrupt) to 10 (no corruption).  Where is your country ranked?",
                ExternalReference = "Corruption",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 10,
                NumTimesPlayed = 0,
                Title = "Corruption",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetRandomDemographics()
        {
            var quiz = new MetaQuiz
            {
                Category = "Demography",
                Description = "Do terrorists come from poor families?  When are emergency rooms busiest?  And other random demography questions.",
                ExternalReference = "Random Demographics",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 13,
                NumTimesPlayed = 0,
                Title = "Random Demographics",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        #endregion
        #region Sociology

        public MetaQuiz GetAmericanSocialStudies()
        {
            var quiz = new MetaQuiz
            {
                Category = "Sociology",
                Description = "Do people think they harm the environment more or less than others?  Does capitalism lead to reduced trust?",
                ExternalReference = "American Social Studies",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 10,
                NumTimesPlayed = 0,
                Title = "American Social Studies",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetConsumerism()
        {
            var quiz = new MetaQuiz
            {
                Category = "Sociology",
                Description = "Question based on industry sponsored research.",
                ExternalReference = "Consumerism",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 10,
                NumTimesPlayed = 0,
                Title = "Consumerism",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetFuture()
        {
            var quiz = new MetaQuiz
            {
                Category = "Sociology",
                Description = "What do most people think will happen in the future?",
                ExternalReference = "Future",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 10,
                NumTimesPlayed = 0,
                Title = "The Future",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetSchoolLifeII()
        {
            var quiz = new MetaQuiz
            {
                Category = "Sociology",
                Description = "What is the most efficient way to study?  And other sociology questions related to young kids and school life.",
                ExternalReference = "School Life II",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 9,
                NumTimesPlayed = 0,
                Title = "School Life II",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetUSTrendsII()
        {
            var quiz = new MetaQuiz
            {
                Category = "Sociology",
                Description = "More questions based on facts from the book 'Microtrends: The small forces behind tomorrow's big changes', from 2009.",
                ExternalReference = "US Trends II",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 17,
                NumTimesPlayed = 0,
                Title = "US Trends II",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetUSTrends()
        {
            var quiz = new MetaQuiz
            {
                Category = "Sociology",
                Description = "Questions based on facts from the book 'Microtrends: The small forces behind tomorrow's big changes', from 2009.",
                ExternalReference = "US Trends",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 14,
                NumTimesPlayed = 0,
                Title = "US Trends",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        #endregion
        #region Experimental Philosophy

        public MetaQuiz GetPainTortureDeath()
        {
            var quiz = new MetaQuiz
            {
                Category = "Experimental Philosophy",
                Description = "Would you torture the fat man?  Who can handle the most pain?",
                ExternalReference = "Pain Torture Death",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 8,
                NumTimesPlayed = 0,
                Title = "Pain, Torture & Death",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetToughMoralChoices()
        {
            var quiz = new MetaQuiz
            {
                Category = "Experimental Philosophy",
                Description = "Should the survivors eat the nearly dead sailor?  Are you bothered by someone lying at their mother's deathbed?",
                ExternalReference = "Tough Moral Choices",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 8,
                NumTimesPlayed = 0,
                Title = "Tough Moral Choices",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        #endregion
        #region Mix

        public MetaQuiz GetNewResearch2012()
        {
            var quiz = new MetaQuiz
            {
                Category = "Mix",
                Description = "Questions based on research that was published in 2012.",
                ExternalReference = "New Research 2012",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 15,
                NumTimesPlayed = 0,
                Title = "New Research 2012",
                TotalScore = 0,
                YearCreated = 2013
            };
            return quiz;
        }

        public MetaQuiz GetNewResearch2013()
        {
            var quiz = new MetaQuiz
            {
                Category = "Mix",
                Description = "Questions based on research that was published in 2013.",
                ExternalReference = "New Research 2013",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 9,
                NumTimesPlayed = 0,
                Title = "New Research 2013",
                TotalScore = 0,
                YearCreated = 2013
            };
            return quiz;
        }

        public MetaQuiz GetOddsAndEnds()
        {
            var quiz = new MetaQuiz
            {
                Category = "Mix",
                Description = "A mix of questions from all sorts of categories.",
                ExternalReference = "Odds and Ends",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 9,
                NumTimesPlayed = 0,
                Title = "Odds & Ends",
                TotalScore = 0,
                YearCreated = 2013
            };
            return quiz;
        }

        public MetaQuiz GetOddsAndEndsII()
        {
            var quiz = new MetaQuiz
            {
                Category = "Mix",
                Description = "A mix of questions from all sorts of categories.",
                ExternalReference = "Odds and Ends II",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 13,
                NumTimesPlayed = 0,
                Title = "Odds & Ends II",
                TotalScore = 0,
                YearCreated = 2013
            };
            return quiz;
        }

        #endregion
    }
}
