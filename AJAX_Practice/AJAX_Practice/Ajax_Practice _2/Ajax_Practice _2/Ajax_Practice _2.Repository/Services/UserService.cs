using Ajax_Practice__2.Helpers.Helpers;
using Ajax_Practice__2.Models.DbContext;
using Ajax_Practice__2.Models.Models;
using Ajax_Practice__2.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajax_Practice__2.Repository.Services
{
    public class UserService: IUser
    {
        KajalPatelEntities db = new KajalPatelEntities();

        public int AddUpdateTeacher(UserModel userModel)
        {
            try
            {
                UserRecord userRecord = new UserRecord();
                userRecord = UserHepler.ConvertToDB(userModel);
                if (userRecord.UserId == 0 && userRecord.UserId > 0) 
                {
                    var check = db.UserRecord.Any(x => x.Name == userModel.Name);
                    if (check)
                    {
                        return 0;
                    }
                    else
                    {
                        db.UserRecord.Add(userRecord);
                        db.SaveChanges();
                        return 1;

                    }
                }
                else
                {
                    db.Entry(userRecord).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return 1;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public List<UserRecord> GetAllUser()
        {
            try
            {
                return db.UserRecord.ToList();

            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public UserModel EditUser(int id)
        {
            try
            {
                UserRecord userRecord = db.UserRecord.Find(id);

                UserModel userModel = UserHepler.ConvertToCustom(userRecord);
                if (userModel != null)
                {
                    return userModel;
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
        public UserRecord DeleteUser(int id)
        {
            try
            {
                var deleteteacher = db.UserRecord.Find(id);
                if (deleteteacher != null)
                {
                    var delete = db.UserRecord.Remove(deleteteacher);
                    db.SaveChanges();
                    return delete;
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
    }
}
