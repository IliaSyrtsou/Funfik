using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Funfik.Core.Interfaces;

namespace Funfik.Core.Services
{
    public class ServiceFactory: IServiceFactory
    {
        Interfaces.EntityServiceInterfaces.IArticleService IServiceFactory.GetArticleService()
        {
            throw new NotImplementedException();
        }

        Interfaces.EntityServiceInterfaces.IArticleRateService IServiceFactory.GetArticleRateService()
        {
            throw new NotImplementedException();
        }

        Interfaces.EntityServiceInterfaces.ICategoryService IServiceFactory.GetCategoryService()
        {
            throw new NotImplementedException();
        }

        Interfaces.EntityServiceInterfaces.IChapterService IServiceFactory.GetChapterService()
        {
            throw new NotImplementedException();
        }

        Interfaces.EntityServiceInterfaces.ITagService IServiceFactory.GetTagService()
        {
            throw new NotImplementedException();
        }

        Interfaces.EntityServiceInterfaces.IUserService IServiceFactory.GetUserService()
        {
            throw new NotImplementedException();
        }
    }
}
