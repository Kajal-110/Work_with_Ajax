using CRUD_with_Ajax.Helpers.Helpers;
using CRUD_with_Ajax.Model.DbContext;
using CRUD_with_Ajax.Model.Models;
using CRUD_with_Ajax.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_with_Ajax.Repository.Services
{
    public class UserServices: IUser
    {
        AjaxPracticeEntities db = new AjaxPracticeEntities();

        public int Register(UserModel userModel)
        {
            try
            {
                User user = new User();
                user = UserHelper.convertToDb(userModel);
                if(user!= null)
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        //public User deleteUser(int id)
        //{
        //    var user = db.Users.Find(id);
        //    if(user != null)
        //    {
        //        var dalete = db.Users.Remove(user);
        //        db.SaveChanges();
        //        return dalete;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
    }
}
