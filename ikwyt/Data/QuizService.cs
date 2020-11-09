using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public List<QuizMetaData> GetQuizMetaData()
        {
            var quizzes = GetQuizzes();
            var results = GetResults();

            var metaData = new List<QuizMetaData>();
            foreach (var quiz in quizzes)
            {
                var quizMetaData = new QuizMetaData
                {
                    Category = quiz.Category, //GetCategoryAsReadableText(quiz.Category),
                    NumQuestions = quiz.Questions.Count,
                    Difficulty = CalculateDifficulty(quiz, results),
                    ExternalReference = quiz.Id,
                    Title = quiz.Title
                };
                quizMetaData.DifficultyValue = CalculateDifficultyValue(quizMetaData.Difficulty);
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
            var quizContent = _database.Content.Single(x => x.ExternalReference == externalReference && x.ContentType == "Quiz");
            var quiz = JsonConvert.DeserializeObject<Quiz>(quizContent.Json);
            var results = GetResults();

            var relevantResults = results.Where(r => r.QuizId == quiz.Id).ToList();
            double averageScore;
            if (relevantResults.Count == 0)
                averageScore = (double)quiz.Questions.Count / 2;
            else
            {
                averageScore = (double)relevantResults.Sum(r => r.Score) / relevantResults.Count;
            }
            return averageScore;
        }

        public void SaveScore(string externalReference, int score)
        {
            var result = new Result
            {
                Id = Guid.NewGuid().ToString(),
                QuizId = externalReference,
                Score = score
            };
            var contentResult = new Content
            {
                ContentId = Guid.NewGuid(),
                ContentType = "Result",
                ExternalReference = externalReference,
                Json = JsonConvert.SerializeObject(result)
            };
            _database.Content.Add(contentResult);
            _database.SaveChanges();
        }

        private List<Quiz> GetQuizzes()
        {
            var quizzesAsJson = _database.Content.Where(x => x.ContentType == "Quiz");
            var quizzes = new List<Quiz>();
            foreach (var quizAsJson in quizzesAsJson)
            {
                var quiz = JsonConvert.DeserializeObject<Quiz>(quizAsJson.Json);
                quizzes.Add(quiz);
            }
            return quizzes;
        }

        private List<Result> GetResults()
        {
            var resultsAsJson = _database.Content.Where(x => x.ContentType == "Result");
            var results = new List<Result>();
            foreach (var resultAsJson in resultsAsJson)
            {
                var result = JsonConvert.DeserializeObject<Result>(resultAsJson.Json);
                results.Add(result);
            }
            return results;
        }

        private int CalculateDifficultyValue(string difficulty)
        {
            if (difficulty == "Very easy")
                return 1;
            if (difficulty == "Easy")
                return 2;
            if (difficulty == "Medium")
                return 3;
            if (difficulty == "Hard")
                return 5;
            if (difficulty == "Very hard")
                return 6;

            // default 
            return 4;
        }

        private string CalculateDifficulty(Quiz quiz, List<Result> results)
        {
            var relevantResults = results.Where(r => r.QuizId == quiz.Id).ToList();
            double averageScore;
            if (relevantResults.Count == 0)
                averageScore = (double)quiz.Questions.Count / 2;
            else
            {
                averageScore = (double)relevantResults.Sum(r => r.Score) / relevantResults.Count;
            }

            var difficulty = averageScore / quiz.Questions.Count;
            if (difficulty < 0.25)
            {
                return "Very hard";
            }
            if (difficulty >= 0.25 && difficulty < 0.4)
            {
                return "Hard";
            }
            if (difficulty >= 0.4 && difficulty < 0.6)
            {
                return "Medium";
            }
            if (difficulty >= 0.6 && difficulty < 0.75)
            {
                return "Easy";
            }
            if (difficulty >= 0.75)
            {
                return "Very easy";
            }
            return "Not calculated";
        }

        private string GetCategoryAsReadableText(string category)
        {
            if (category == "BehavioralEconomics")
                return "Behavioral Economics";
            if (category == "Demography")
                return "Demography";
            if (category == "Psychology")
                return "Psychology";
            if (category == "ExperimentalPhilosophy")
                return "Experimental Philosophy";
            if (category == "Biology")
                return "Biology";
            if (category == "Mixed")
                return "Mixed";
            return "Uncategorized";
        }
    }
}
