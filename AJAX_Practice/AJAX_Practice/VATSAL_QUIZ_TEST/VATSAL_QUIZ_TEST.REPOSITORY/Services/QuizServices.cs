using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VATSAL_QUIZ_TEST.MODELS.Context;
using VATSAL_QUIZ_TEST.REPOSITORY.Repository;

namespace VATSAL_QUIZ_TEST.REPOSITORY.Services
{
    public class QuizServices : IQuizInterface
    {
        VATSALQUIZTESTEntities db = new VATSALQUIZTESTEntities();

        public List<Answer> AnswerList()
        {
            try
            {
                List<Answer> answers = db.Answers.Where(x => x.isactive == true).ToList();
                if (answers != null)
                {
                    return answers;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Question> QuestionList()
        {
            try
            {
                List<Question> question = db.Questions.Where(x => x.isactive == true).ToList();
                if (question != null)
                {
                    return question;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
