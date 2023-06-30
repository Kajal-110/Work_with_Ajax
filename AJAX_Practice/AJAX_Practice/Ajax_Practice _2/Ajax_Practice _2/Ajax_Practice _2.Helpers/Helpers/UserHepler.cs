using Ajax_Practice__2.Models.DbContext;
using Ajax_Practice__2.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajax_Practice__2.Helpers.Helpers
{
    public static class UserHepler
    {
        public static UserRecord ConvertToDB(UserModel um)
        {
            UserRecord ur = new UserRecord();
            ur.UserId = um.UserId;
            ur.Name = um.Name;
            ur.Address = um.Address;
            ur.Gender = um.Gender;
            ur.Role = um.Role;
            ur.DOB = um.DOB;
            ur.PhoneNo = um.PhoneNo;
            ur.Email = um.Email;
            ur.Password = um.Password;
            ur.isDeleted = ur.isDeleted;
            return ur;

            //userModel.DOBFormat = user.DOB.HasValue && user.DOB != null ? user.DOB.Value.ToString("yyyy-MM-dd") : "";
        }

        public static UserModel ConvertToCustom(UserRecord um)
        {
            UserModel ur = new UserModel();
            ur.UserId = um.UserId;
            ur.Name = um.Name;
            ur.Address = um.Address;
            ur.Gender = um.Gender;
            ur.Role = um.Role;
            ur.DOBFormat = um.DOB.HasValue &&  um.DOB !=  null ?um.DOB.Value.ToString("yyyy-MM-dd"): "";
            ur.PhoneNo = um.PhoneNo;
            ur.Email = um.Email;
            ur.Password = um.Password;
            ur.isDeleted = ur.isDeleted;
            return ur;
        }

        public static List<UserModel> ConvertToCustomModel(List<UserRecord> um)
        {
            try
            {
                List<UserModel> UserList = new List<UserModel>();
                foreach (var item in um)
                {
                    UserModel ur = new UserModel();
                    ur.UserId = item.UserId;
                    ur.Name = item.Name;
                    ur.Address = item.Address;
                    ur.Gender = item.Gender;
                    ur.Role = item.Role;
                    ur.DOBFormat = item.DOB.HasValue && item.DOB != null ? item.DOB.Value.ToString("yyyy-MM-dd") : "";
                    ur.PhoneNo = item.PhoneNo;
                    ur.Email = item.Email;
                    ur.Password = item.Password;
                    ur.isDeleted = item.isDeleted;
                    UserList.Add(ur);
                }
                return UserList;
            }
            catch (Exception e)
            {

                throw e;
            }

        }
    }
}
