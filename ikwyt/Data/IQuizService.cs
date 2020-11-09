using Repository;
using System.Collections.Generic;

namespace IKWYT.Data
{
    public interface IQuizService
    {
        List<QuizMetaData> GetQuizMetaData();
        Quiz GetQuiz(string externalReference);
        double GetAverageScore(string externalReference);
        void SaveScore(string externalReference, int score);
    }
}
