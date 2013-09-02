using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Funfik.Core.Interfaces.EntityServiceInterfaces;
using WebMatrix.WebData;

namespace Funfik.Web.Areas.Default.Controllers
{
    public partial class LikeController : Controller
    {
        private ILikeService LikeService { get; set; }

        private IArticleService ArticleService { get; set; }

        public LikeController(ILikeService likeService, IArticleService articleService)
        {
            LikeService = likeService;
            ArticleService = articleService;
        }
        //
        // GET: /Default/Like/

        public virtual ActionResult Index()
        {
            return RedirectToAction(MVC.Default.Home.Index());
        }

        public virtual ActionResult LikeArticle(int articleId)
        {
            LikeService.LikeArticle(articleId, WebSecurity.CurrentUserId);

            return PartialView(MVC.Default.Article.Views._ShowLikes, ArticleService.GetArticleById(articleId));
        }

        public virtual ActionResult DislikeArticle(int articleId)
        {
            LikeService.DislikeArticle(articleId, WebSecurity.CurrentUserId);

            return PartialView(MVC.Default.Article.Views._ShowLikes, ArticleService.GetArticleById(articleId));
        }

    }
}
