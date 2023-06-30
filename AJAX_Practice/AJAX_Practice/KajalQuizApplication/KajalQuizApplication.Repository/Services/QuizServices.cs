using KajalQuizApplication.Models.DbContext;
using KajalQuizApplication.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KajalQuizApplication.Repository.Services
{
    public class QuizServices: IQuiz
    {
        QuestionManagementEntities db = new QuestionManagementEntities();

        public List<Question> GetQuestions()
        {
            try
            {
                List<Question> questions = db.Question.Where(x => x.IsActive == true).ToList();
                if(questions != null)
                {
                    return questions;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public List<Answer> GetAnswers()
        {
            try
            {
                List<Answer> answers = db.Answer.Where(x => x.IsActive == true).ToList();
                if(answers!= null)
                {
                    return answers;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
