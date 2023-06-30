using KajalQuizApplication.Repository.Repository;
using KajalQuizApplication.Repository.Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace KajalQuizApplication
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IUser, UserServices>();
            container.RegisterType<IQuiz, QuizServices>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}