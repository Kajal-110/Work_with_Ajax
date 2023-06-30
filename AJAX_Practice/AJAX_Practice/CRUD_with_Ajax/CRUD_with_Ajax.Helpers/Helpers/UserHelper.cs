using CRUD_with_Ajax.Model.DbContext;
using CRUD_with_Ajax.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_with_Ajax.Helpers.Helpers
{
    public class UserHelper
    {
        public static User convertToDb(UserModel userModel)
        {
            User user = new User();
            user.UserId = userModel.UserId;
            user.UserName = userModel.UserName;
            user.Address = userModel.Address;
            user.Gender = userModel.Gender;
            user.DOB = userModel.DOB;
            user.PhoneNo = userModel.PhoneNo;
            user.Role = userModel.Role;
            user.IsDeleted = userModel.IsDeleted;
            return user;
        }
    }
}
