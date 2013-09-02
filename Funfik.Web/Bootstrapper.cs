using System.Web.Mvc;
using Funfik.Core.Interfaces.EntityServiceInterfaces;
using Funfik.Core.Interfaces.HelperServiceInterfaces;
using Funfik.Core.Services.EntityServices;
using Funfik.Core.Services.HelperServices;
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

            container.RegisterType<IArticleService, ArticleService>();
            container.RegisterType<ILikeService, LikeService>();
            container.RegisterType<ICategoryService, CategoryService>();
            container.RegisterType<IChapterService, ChapterService>();
            container.RegisterType<ITagService, TagService>();
            container.RegisterType<IUserService, UserService>();

            container.RegisterType<IMailService, MailService>();

            return container;
        }
    }
}