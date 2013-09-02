using Funfik.Core.DataAccess;
using Funfik.Core.Entities;
using Funfik.Core.Interfaces.EntityServiceInterfaces;
using System.Linq;
using WebMatrix.WebData;

using System.Collections.Generic;
namespace Funfik.Core.Services.EntityServices
{
    /// <summary>
    /// A service which provides like-related functionality.
    /// </summary>
    public class LikeService : ILikeService
    {
        private FunfikDb Database { get; set; }

        public LikeService()
        {
            Database = new FunfikDb();
        }

        void ILikeService.LikeArticle(int articleId, int userId)
        {   
            var like = new Like();
            like.ArticleId = articleId;
            like.UserId = userId;
            if (Database.Articles.FirstOrDefault(x=> x.ArticleId == articleId)
                        .Likes.FirstOrDefault(x=> x.UserId == userId) == null)
            {
                Database.Likes.Add(like);
                Database.SaveChanges();
            }
        }


        void ILikeService.DislikeArticle(int articleId, int userId)
        {
            Database.Likes.Remove(Database.Likes.FirstOrDefault(
                like => like.ArticleId == articleId && like.UserId == userId));
            Database.SaveChanges();
        }
    }
}
