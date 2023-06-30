using KajalQuizApplication.Models.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KajalQuizApplication.Repository.Repository
{
    public interface IQuiz
    {
        List<Question> GetQuestions();
        List<Answer> GetAnswers();
    }
}
