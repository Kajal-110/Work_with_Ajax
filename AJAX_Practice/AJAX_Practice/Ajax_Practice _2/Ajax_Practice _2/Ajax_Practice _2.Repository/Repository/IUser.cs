using Ajax_Practice__2.Models.DbContext;
using Ajax_Practice__2.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajax_Practice__2.Repository.Repository
{
    public interface IUser
    {
         int AddUpdateTeacher(UserModel userModel);
         List<UserRecord> GetAllUser();
         UserModel EditUser(int id);
         UserRecord DeleteUser(int id);
    }
}
