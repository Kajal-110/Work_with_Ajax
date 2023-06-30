using CRUD_with_Ajax.Model.DbContext;
using CRUD_with_Ajax.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_with_Ajax.Repository.Repository
{
    public interface ITeacher
    {
        int AddUpdateTeacher(TeacherModel teacherModel);
        TeacherModel EditTeacher(int id);
        Teacher DeleteTecher(int id);

        List<Teacher> GetAllTeacher();
    }
}
