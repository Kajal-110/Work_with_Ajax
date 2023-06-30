using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_with_Ajax.Model.Models
{
    public class TeacherModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]

        [StringLength(100)]

        public string Name { get; set; }
        [Required (ErrorMessage = "Address is required")]
        [StringLength(200)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Genger is required")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please Select your DOB ")]
        public Nullable<System.DateTime> Date { get; set; }
    }
}
