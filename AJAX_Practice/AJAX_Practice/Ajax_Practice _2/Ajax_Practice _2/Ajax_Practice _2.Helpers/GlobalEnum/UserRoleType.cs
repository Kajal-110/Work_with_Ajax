using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajax_Practice__2.Helpers.GlobalEnum
{
    public enum UserRoleType
    {
        [Display(Name = " Admin")]
        SuperAdmin = 1,
        [Display(Name = " Manager")]
        Admin = 2,
        [Display(Name = "Customer")]
        User = 3
    }
}
