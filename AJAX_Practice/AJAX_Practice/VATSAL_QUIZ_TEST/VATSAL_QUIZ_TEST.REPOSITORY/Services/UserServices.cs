using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VATSAL_QUIZ_TEST.MODELS.Context;
using VATSAL_QUIZ_TEST.MODELS.Model;
using VATSAL_QUIZ_TEST.REPOSITORY.Repository;

namespace VATSAL_QUIZ_TEST.REPOSITORY.Services
{
    public class UserServices : IUserInterface
    {
        VATSALQUIZTESTEntities db = new VATSALQUIZTESTEntities();
        public int LoginVerify(UserDataModel user)
        {
            try
            {
                
                if (db.USERDATAs.Any(x => x.EMAIL == user.EMAIL))
                {
                    if (db.USERDATAs.Any(x => x.EMAIL == user.EMAIL && x.PASSWORD == user.PASSWORD))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                else
                {
                    return 3;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
