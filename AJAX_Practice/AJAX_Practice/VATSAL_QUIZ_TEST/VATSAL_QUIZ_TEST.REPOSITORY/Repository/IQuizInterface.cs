using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VATSAL_QUIZ_TEST.MODELS.Context;

namespace VATSAL_QUIZ_TEST.REPOSITORY.Repository
{
    public interface IQuizInterface
    {
        List<Question> QuestionList();
        List<Answer> AnswerList();
    }
}
