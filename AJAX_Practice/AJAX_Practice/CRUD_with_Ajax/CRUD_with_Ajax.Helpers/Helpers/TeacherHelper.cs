using CRUD_with_Ajax.Model.DbContext;
using CRUD_with_Ajax.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_with_Ajax.Helpers.Helpers
{
    public static class TeacherHelper
    {
        public static Teacher ConvertToDB(TeacherModel teacherModel)
        {
            Teacher teacher = new Teacher();
            teacher.Id = teacherModel.Id;
            teacher.Name = teacherModel.Name;
            teacher.Address = teacherModel.Address;
            teacher.Gender = teacherModel.Gender;
            teacher.Date = teacherModel.Date;
            return teacher;
        }

        public static TeacherModel ConvertToCustome(Teacher teacher)
        {
            TeacherModel teacherModel = new TeacherModel();
            teacherModel.Id = teacher.Id;
            teacherModel.Name = teacher.Name;
            teacherModel.Address = teacher.Address;
            teacherModel.Gender = teacher.Gender;
            teacherModel.Date = teacher.Date;
            return teacherModel;
        }
    }
}
