using CRUD_with_Ajax.Model.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_with_Ajax.Model.Models
{
    public class PageModel
    {
        public List<Teacher> Teacher { get; set; }

      
        public int CurrentPageIndex { get; set; }

       
        public int PageCount { get; set; }
    }
}
