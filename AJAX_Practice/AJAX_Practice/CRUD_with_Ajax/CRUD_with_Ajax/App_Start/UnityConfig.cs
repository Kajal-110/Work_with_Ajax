using CRUD_with_Ajax.Repository.Repository;
using CRUD_with_Ajax.Repository.Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace CRUD_with_Ajax
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType< IUser, UserServices>();
            container.RegisterType<ITeacher, TeacherService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}