using CRUD_with_Ajax.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_with_Ajax.Repository.Repository
{
    public interface IUser
    {
        int Register(UserModel userModel);
        //User deleteUser(int id);
    }
}
