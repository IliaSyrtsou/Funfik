using Funfik.Core.Entities;

namespace Funfik.Core.Interfaces.EntityServiceInterfaces
{
    /// <summary>
    /// An interface for like-related functionality.
    /// </summary>
    public interface ILikeService
    {
        /// <summary>
        /// Likes an article with given article id.
        /// </summary>
        void LikeArticle(int articleId, int userId);

        /// <summary>
        /// Dislikes an article with given article id.
        /// </summary>
        void DislikeArticle(int articleId, int userId);
    }
}
