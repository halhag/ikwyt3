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
            //metaQuizzes.Add(GetDifficultChoices());
            //metaQuizzes.Add(GetAltruism());
            //metaQuizzes.Add(GetRelativeValues());
            //metaQuizzes.Add(GetRewardsAndBonuses());
            //metaQuizzes.Add(GetRevenge());
            //metaQuizzes.Add(GetRewardsPunishmentHappiness());
            //metaQuizzes.Add(GetSocialNorms());
            //metaQuizzes.Add(GetOrderingFoodBeveragesII());
            //metaQuizzes.Add(GetOrderingFoodBeverages());

            //// Biology
            //metaQuizzes.Add(GetBody());
            //metaQuizzes.Add(GetBrain());
            //metaQuizzes.Add(GetMeditationExercise());
            //metaQuizzes.Add(GetTime());

            //// Demography
            //metaQuizzes.Add(GetComparingCountries());
            //metaQuizzes.Add(GetCorruption());
            //metaQuizzes.Add(GetRandomDemographics());

            //// Sociology
            //metaQuizzes.Add(GetAmericanSocialStudies());
            //metaQuizzes.Add(GetConsumerism());
            //metaQuizzes.Add(GetFuture());
            //metaQuizzes.Add(GetSchoolLifeII());
            //metaQuizzes.Add(GetUSTrendsII());
            //metaQuizzes.Add(GetUSTrends());

            //// Experimental philosophy
            //metaQuizzes.Add(GetPainTortureDeath());
            //metaQuizzes.Add(GetToughMoralChoices());

            //// Mix
            //metaQuizzes.Add(GetEasyWarmup());
            //metaQuizzes.Add(GetNewResearch2012());
            //metaQuizzes.Add(GetNewResearch2013());
            //metaQuizzes.Add(GetOddsAndEnds());
            //metaQuizzes.Add(GetOddsAndEndsII());

            //// Psychology
            //metaQuizzes.Add(GetAssessments());
            //metaQuizzes.Add(GetBeautyTalentStatus());
            //metaQuizzes.Add(GetSelfDeception());
            //metaQuizzes.Add(GetDishonesty());
            //metaQuizzes.Add(GetDishonestyII());
            //metaQuizzes.Add(GetDishonestyIII());
            //metaQuizzes.Add(GetGenderDifferences());
            //metaQuizzes.Add(GetGenderDifferencesII());
            //metaQuizzes.Add(GetGroupPressure());
            //metaQuizzes.Add(GetIndividualsVsGroups());
            //metaQuizzes.Add(GetChildrenAndAnimals());
            //metaQuizzes.Add(GetCocaCola());
            //metaQuizzes.Add(GetFamousExperiments());
            //metaQuizzes.Add(GetObedience());
            //metaQuizzes.Add(GetSchoolLife());
            //metaQuizzes.Add(GetThinking());

            // Warmup
            //metaQuizzes.Add(GetCocaCola());
            //metaQuizzes.Add(GetEasyWarmup());
            //metaQuizzes.Add(GetFamousExperiments());
            //metaQuizzes.Add(GetPainTortureDeath());

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

        public MetaQuiz GetEasyWarmup()
        {
            var quiz = new MetaQuiz
            {
                Category = "Mix",
                Description = "Easy warmup questions from different categories.",
                ExternalReference = "Easy Warmup",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 8,
                NumTimesPlayed = 0,
                Title = "Easy Warmup",
                TotalScore = 0,
                YearCreated = 2013
            };
            return quiz;
        }

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
        #region Psychology

        public MetaQuiz GetAssessments()
        {
            var quiz = new MetaQuiz
            {
                Category = "Psychology",
                Description = "Questions based on the award winning research by Kahneman and Tversky.  Kahneman won the Nobel prize in 2002 for his work with Tversky, but since Tversky was then by dead he did not receive the prize.",
                ExternalReference = "Assessments",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 14,
                NumTimesPlayed = 0,
                Title = "Assessments",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetBeautyTalentStatus()
        {
            var quiz = new MetaQuiz
            {
                Category = "Psychology",
                Description = "Does everyone agree on what beauty is?  Does everyone agree what a good personality is?  Does social status impact performance?",
                ExternalReference = "Beauty Talent Status",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 8,
                NumTimesPlayed = 0,
                Title = "Beauty, Talent & Status",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetSelfDeception()
        {
            var quiz = new MetaQuiz
            {
                Category = "Psychology",
                Description = "Who washed their hands the most?  For or against the death penalty?  Do you remember your grades from school?  How many thought they would perform better than they did?",
                ExternalReference = "Self Deception",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 12,
                NumTimesPlayed = 0,
                Title = "Self Deception",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetDishonesty()
        {
            var quiz = new MetaQuiz
            {
                Category = "Psychology",
                Description = "Do most people cheat blind people?  How much do golfers really cheat?",
                ExternalReference = "Dishonesty",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 9,
                NumTimesPlayed = 0,
                Title = "Dishonesty",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetDishonestyII()
        {
            var quiz = new MetaQuiz
            {
                Category = "Psychology",
                Description = "When cheating, do we also deceive ourselves?  Did financial incentives make them guess more correctly?  Who cheated more on exams?",
                ExternalReference = "Dishonesty_ii",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 15,
                NumTimesPlayed = 0,
                Title = "Dishonesty II",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetDishonestyIII()
        {
            var quiz = new MetaQuiz
            {
                Category = "Psychology",
                Description = "Who cheats on their travel expenses?  What do you eat when you are tired?  What is the effect on your tests if you wear fake sunglasses?",
                ExternalReference = "Dishonesty_iii",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 11,
                NumTimesPlayed = 0,
                Title = "Dishonesty III",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetGenderDifferences()
        {
            var quiz = new MetaQuiz
            {
                Category = "Psychology",
                Description = "Who improves most when given monetary rewards, men or women?  What happens to your salary when you have a sex change operation?  Are women doctors better than male doctors?",
                ExternalReference = "Gender Differences",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 11,
                NumTimesPlayed = 0,
                Title = "Gender Differences",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetGenderDifferencesII()
        {
            var quiz = new MetaQuiz
            {
                Category = "Psychology",
                Description = "Are male entrepreneurs better than female entrepreneurs?  Are men better at negotiation their salary then women?",
                ExternalReference = "Gender Differences II",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 10,
                NumTimesPlayed = 0,
                Title = "Gender Differences II",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetGroupPressure()
        {
            var quiz = new MetaQuiz
            {
                Category = "Psychology",
                Description = "Are Japanese people more likely to conform to what the group does?  Does group pressure make you pay more taxes?",
                ExternalReference = "Group pressure",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 8,
                NumTimesPlayed = 0,
                Title = "Group Pressure",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetIndividualsVsGroups()
        {
            var quiz = new MetaQuiz
            {
                Category = "Psychology",
                Description = "How many think they are above average?  How many fund managers perform better than the index?  Is the average of the group a good indicator of the correct result?",
                ExternalReference = "Individuals vs Groups",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 9,
                NumTimesPlayed = 0,
                Title = "Individuals vs. Groups",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetChildrenAndAnimals()
        {
            var quiz = new MetaQuiz
            {
                Category = "Psychology",
                Description = "How often do small children considered good do what their parents tell them?  Do children prefer forbidden toys?  Do animals prefer to work for their food?  Do animals exact revenge?",
                ExternalReference = "Children and Animals",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 13,
                NumTimesPlayed = 0,
                Title = "Children & Animals",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetCocaCola()
        {
            var quiz = new MetaQuiz
            {
                Category = "Psychology",
                Description = "Would you taste the difference between Coke and Pepsi in a blind test?  Which one do people prefer in a blind test?",
                ExternalReference = "Coca Cola",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 10,
                NumTimesPlayed = 0,
                Title = "Coca Cola",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetFamousExperiments()
        {
            var quiz = new MetaQuiz
            {
                Category = "Psychology",
                Description = "Pavlov, Milgram, Rosenhan, Harlow and more:  These are questions from the most famous experiments in psychology.",
                ExternalReference = "Famous Experiments",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 8,
                NumTimesPlayed = 0,
                Title = "Famous Experiments",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetObedience()
        {
            var quiz = new MetaQuiz
            {
                Category = "Psychology",
                Description = "Are most people obedient?  Are Germans more obedient than Americans?  Including questions from Milgram's famous experiment.",
                ExternalReference = "Obedience",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 8,
                NumTimesPlayed = 0,
                Title = "Obedience",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetSchoolLife()
        {
            var quiz = new MetaQuiz
            {
                Category = "Psychology",
                Description = "Would you take a dollar bill lying in a communal fridge?  What is the best way to study?  And more questions from books by Dan Ariely.",
                ExternalReference = "School Life",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 8,
                NumTimesPlayed = 0,
                Title = "School Life",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        public MetaQuiz GetThinking()
        {
            var quiz = new MetaQuiz
            {
                Category = "Psychology",
                Description = "How good is your short term memory?  Does prayer help non-religious people?",
                ExternalReference = "Thinking",
                LastPlayed = DateTime.MinValue,
                NumQuestions = 8,
                NumTimesPlayed = 0,
                Title = "Thinking",
                TotalScore = 0,
                YearCreated = 2012
            };
            return quiz;
        }

        #endregion
    }
}
