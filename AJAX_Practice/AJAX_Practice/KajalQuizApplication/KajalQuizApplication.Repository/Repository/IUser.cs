using KajalQuizApplication.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KajalQuizApplication.Repository.Repository
{
    public interface IUser
    {
        string Login(UserModel userModel);
    }
}
