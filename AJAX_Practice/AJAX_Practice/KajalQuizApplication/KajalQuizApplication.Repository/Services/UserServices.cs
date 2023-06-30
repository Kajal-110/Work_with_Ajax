using KajalQuizApplication.Models.DbContext;
using KajalQuizApplication.Models.Model;
using KajalQuizApplication.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KajalQuizApplication.Repository.Services
{
    public class UserServices: IUser
    {
        QuestionManagementEntities db = new QuestionManagementEntities();

        public string Login (UserModel userModel)
        {
            try
            {
                var email = db.User.Where(x => x.Email == userModel.Email).FirstOrDefault();
                var pass = db.User.Where(x => x.Password == userModel.Password).FirstOrDefault();
                if (email == null && pass == null)
                {
                    return "Invalid Email and Password ";

                }
                else if (email != null)
                {
                    if (email.Password != userModel.Password)
                    {
                        return "Invalid Password";
                    }
                    else
                    {
                        return email.Email;
                    }
                }
                else
                {
                    return "Invalid Email";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
