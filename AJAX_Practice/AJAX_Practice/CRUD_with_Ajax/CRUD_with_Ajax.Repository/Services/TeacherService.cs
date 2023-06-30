using CRUD_with_Ajax.Helpers.Helpers;
using CRUD_with_Ajax.Model.DbContext;
using CRUD_with_Ajax.Model.Models;
using CRUD_with_Ajax.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_with_Ajax.Repository.Services
{
    public class TeacherService: ITeacher
    {
        AjaxPracticeEntities db = new AjaxPracticeEntities();

        public int AddUpdateTeacher(TeacherModel teacherModel)
        {
            try
            {
                Teacher teacher = new Teacher();
                teacher = TeacherHelper.ConvertToDB(teacherModel);
                if (teacherModel.Id ==0)
                {
                    var CheckExistOrNot = db.Teachers.Any(x => x.Name == teacherModel.Name);
                    if (CheckExistOrNot)
                    {
                        return 0;
                    }
                    else
                    {
                        db.Teachers.Add(teacher);
                        db.SaveChanges();
                        return 1;

                    }
                }                                   
                else
                {
                    db.Entry(teacher).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return 1;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public List<Teacher> GetAllTeacher()
        {
            try
            {
                return db.Teachers.ToList();

            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public TeacherModel EditTeacher(int id)
        {
            try
            {
                Teacher teacher = db.Teachers.Find(id);
                TeacherModel teacherModel = TeacherHelper.ConvertToCustome(teacher);
                if(teacherModel != null)
                {
                    return teacherModel;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public Teacher DeleteTecher(int id)
        {
            try
            {
                var deleteteacher = db.Teachers.Find(id);
                if (deleteteacher != null)
                {
                    var delete = db.Teachers.Remove(deleteteacher);
                    db.SaveChanges();
                    return delete;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
