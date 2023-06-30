using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATSAL_QUIZ_TEST.MODELS.Model
{
    public class UserDataModel
    {
        [Required]
        public string EMAIL { get; set; }
        [Required]
        public string PASSWORD { get; set; }
    }
}
