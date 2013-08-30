using System.Web.Mvc;
using Funfik.Core.DataAccess;
using Microsoft.Practices.Unity;
using Unity.Mvc3;

namespace Funfik.Web
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IUserDataSource, UserDb>();           

            return container;
        }
    }
}