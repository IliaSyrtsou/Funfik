using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Funfik.Core.Interfaces.EntityServiceInterfaces;

namespace Funfik.Core.Interfaces
{
    /// <summary>
    /// An interface for operations that create entity business services.
    /// </summary>
    public interface IServiceFactory
    {
        IArticleService GetArticleService();

        IArticleRateService GetArticleRateService();    

        ICategoryService GetCategoryService();

        IChapterService GetChapterService();

        ITagService GetTagService();

        IUserService GetUserService();
    }
}
