using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using VATSAL_QUIZ_TEST.REPOSITORY.Repository;
using VATSAL_QUIZ_TEST.REPOSITORY.Services;

namespace VATSAL_QUIZ_TEST
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IUserInterface, UserServices>();
            container.RegisterType<IQuizInterface, QuizServices>();
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}