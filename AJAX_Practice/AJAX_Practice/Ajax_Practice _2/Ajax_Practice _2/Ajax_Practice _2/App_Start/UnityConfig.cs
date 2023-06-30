using Ajax_Practice__2.Repository.Repository;
using Ajax_Practice__2.Repository.Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Ajax_Practice__2
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IUser, UserService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}