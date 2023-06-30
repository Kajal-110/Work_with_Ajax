using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_with_Ajax.Model.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public Nullable<System.DateTime> DOB { get; set; }
        [Required]
        public string PhoneNo { get; set; }
        [Required]
        public Nullable<int> Role { get; set; }
        [Required]
        public Nullable<bool> IsDeleted { get; set; }
    }
}
