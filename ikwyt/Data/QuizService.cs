using System;
using System.Collections.Generic;
using System.Linq;
using Meta;
using Newtonsoft.Json;
using Repository;

namespace IKWYT.Data
{
    public class QuizService : IQuizService
    {
        private readonly Database _database;

        public QuizService(Database database)
        {
            _database = database;
        }

        // Only for adding new data - comment in button in Quizzes.razor and code for OnChange there to make it work locally
        public void SaveMeta()
        {
            var metaQuizzes = new MetaQuizzes();
            var metas = metaQuizzes.GetAll();
            foreach (var meta in metas)
            {
                var content = new Content
                {
                    ContentId = Guid.NewGuid(),
                    ContentType = "Meta",
                    ExternalReference = meta.ExternalReference,
                    Json = JsonConvert.SerializeObject(meta)
                };
                _database.Content.Add(content);
            }
            _database.SaveChanges();
        }

        public List<QuizMetaData> GetQuizMetaData()
        {
            var quizzes = GetQuizzes();

            var metaData = new List<QuizMetaData>();
            foreach (var quiz in quizzes)
            {
                var difficulty = CalculateDifficulty(quiz);
                var quizMetaData = new QuizMetaData
                {
                    Category = quiz.Category, //GetCategoryAsReadableText(quiz.Category),
                    NumQuestions = quiz.NumQuestions,
                    Difficulty = difficulty.Name,
                    DifficultyValue = difficulty.Score,
                    UnderlyingDifficulty = difficulty.UnderlyingValue,
                    ExternalReference = quiz.ExternalReference,
                    Title = quiz.Title,
                    Description = quiz.Description,
                    LastPlayed = quiz.LastPlayed,
                    NumTimesPlayed = quiz.NumTimesPlayed
                };
                metaData.Add(quizMetaData);
            }

            return metaData;
        }

        public Quiz GetQuiz(string externalReference)
        {
            var quizContent = _database.Content.Single(x => x.ExternalReference == externalReference && x.ContentType == "Quiz");
            var quiz = JsonConvert.DeserializeObject<Quiz>(quizContent.Json);
            return quiz;
        }

        public double GetAverageScore(string externalReference)
        {
            var meta = _database.Content.Single(x => x.ExternalReference == externalReference && x.ContentType == "Meta");
            var quiz = JsonConvert.DeserializeObject<MetaQuiz>(meta.Json);

            double averageScore;
            if (quiz.NumTimesPlayed == 0)
                averageScore = (double)quiz.NumQuestions / 2;
            else
            {
                averageScore = (double)quiz.TotalScore / quiz.NumTimesPlayed;
            }
            return averageScore;
        }

        public void SaveScore(string externalReference, int score)
        {
            var meta = _database.Content.Single(x => x.ExternalReference == externalReference && x.ContentType == "Meta");
            var quiz = JsonConvert.DeserializeObject<MetaQuiz>(meta.Json);

            quiz.TotalScore += score;
            quiz.LastPlayed = DateTime.Now;
            quiz.NumTimesPlayed++;

            meta.Json = JsonConvert.SerializeObject(quiz);
            _database.SaveChanges();
        }

        private List<MetaQuiz> GetQuizzes()
        {
            var quizzesAsJson = _database.Content.Where(x => x.ContentType == "Meta");
            var quizzes = new List<MetaQuiz>();
            foreach (var quizAsJson in quizzesAsJson)
            {
                var quiz = JsonConvert.DeserializeObject<MetaQuiz>(quizAsJson.Json);
                quizzes.Add(quiz);
            }
            return quizzes;
        }

        private Difficulty CalculateDifficulty(MetaQuiz quiz)
        {
            double averageScore;
            if (quiz.NumTimesPlayed == 0)
                averageScore = (double)quiz.NumQuestions / 2;
            else
            {
                averageScore = (double)quiz.TotalScore / quiz.NumTimesPlayed;
            }

            var difficulty = averageScore / quiz.NumQuestions;
            if (difficulty < 0.25)
            {
                return new Difficulty
                {
                    Name = "Very hard",
                    Score = 6,
                    UnderlyingValue = difficulty
                };
            }
            if (difficulty >= 0.25 && difficulty < 0.4)
            {
                return new Difficulty 
                {
                    Name = "Hard",
                    Score = 5,
                    UnderlyingValue = difficulty
                };
            }
            if (difficulty >= 0.4 && difficulty < 0.6)
            {
                return new Difficulty
                {
                    Name = "Medium",
                    Score = 3,
                    UnderlyingValue = difficulty
                };
            }
            if (difficulty >= 0.6 && difficulty < 0.75)
            {
                return new Difficulty
                {
                    Name = "Easy",
                    Score = 2,
                    UnderlyingValue = difficulty
                };
            }
            if (difficulty >= 0.75)
            {
                return new Difficulty
                {
                    Name = "Very easy",
                    Score = 1,
                    UnderlyingValue = difficulty
                };
            }
            return new Difficulty
            {
                Name = "Not calculated",
                Score = 4,
                UnderlyingValue = difficulty
            };
        }

        //private string GetCategoryAsReadableText(string category)
        //{
        //    if (category == "BehavioralEconomics")
        //        return "Behavioral Economics";
        //    if (category == "Demography")
        //        return "Demography";
        //    if (category == "Psychology")
        //        return "Psychology";
        //    if (category == "ExperimentalPhilosophy")
        //        return "Experimental Philosophy";
        //    if (category == "Biology")
        //        return "Biology";
        //    if (category == "Mixed")
        //        return "Mixed";
        //    return "Uncategorized";
        //}

        //private List<Result> GetResults()
        //{
        //    var resultsAsJson = _database.Content.Where(x => x.ContentType == "Result");
        //    var results = new List<Result>();
        //    foreach (var resultAsJson in resultsAsJson)
        //    {
        //        var result = JsonConvert.DeserializeObject<Result>(resultAsJson.Json);
        //        results.Add(result);
        //    }
        //    return results;
        //}

        //public void SaveScore(string externalReference, int score)
        //{
        //    var result = new Result
        //    {
        //        Id = Guid.NewGuid().ToString(),
        //        QuizId = externalReference,
        //        Score = score
        //    };
        //    var contentResult = new Content
        //    {
        //        ContentId = Guid.NewGuid(),
        //        ContentType = "Result",
        //        ExternalReference = externalReference,
        //        Json = JsonConvert.SerializeObject(result)
        //    };
        //    _database.Content.Add(contentResult);
        //    _database.SaveChanges();
        //}
    }
}
