using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Funfik.Core.Entities;
using Funfik.Core.DataAccess;
using Funfik.Core.Interfaces.EntityServiceInterfaces;
using WebMatrix.WebData;

namespace Funfik.Web.Areas.Default.Controllers
{
    [Authorize]
    public partial class ArticleController : Controller
    {
        private FunfikDb context = new FunfikDb();
        private IArticleService ArticleService { get; set; }
        private IChapterService ChapterService { get; set; }
        private ICategoryService CategoryService { get; set; }

        public ArticleController(IArticleService articleService, IChapterService chapterService)
        {
            ArticleService = articleService;
            ChapterService = chapterService;
        }

        //
        //GET: /Article/Best
        [AllowAnonymous]
        public virtual ActionResult Best()
        {
            return View(ArticleService.GetBestArticles());
        }

        //
        // GET: /Article/Details/5
        [AllowAnonymous]
        public virtual ViewResult Details(int id)
        {
            return View(ArticleService.GetArticleById(id));
        }

        //
        // GET: /Article/Create

        public virtual ActionResult Create()
        {
            ViewBag.PossibleCategories = context.Categories;
            return View();
        } 

        //
        // POST: /Article/Create

        [HttpPost]
        public virtual ActionResult Create(Article article)
        {
            if (ModelState.IsValid)
            {
                ArticleService.AddArticle(article);
                return RedirectToAction(MVC.Default.Article.UserArticles());  
            }
            ViewBag.PossibleCategories = CategoryService.GetCategories();
            return View(article);
        }
        
        //
        // GET: /Article/Edit/5

        public virtual ActionResult Edit(int id)
        {
            var article = ArticleService.GetArticleById(id);
            ViewBag.PossibleCategories = CategoryService.GetCategories();
            return View(article);
        }

        //
        // POST: /Article/Edit/5

        [HttpPost]
        public virtual ActionResult Edit(Article article)
        {
            if (ModelState.IsValid)
            {
                ArticleService.UpdateArticle(article);
                
                return RedirectToAction(MVC.Default.Article.UserArticles());
            }
            ViewBag.PossibleCategories = CategoryService.GetCategories();
            return View(article);
        }

        //
        // GET: /Article/Delete/5

        public virtual ActionResult Delete(int id)
        {
            Article article = context.Articles.Single(x => x.ArticleId == id);
            return View(article);
        }

        //
        // POST: /Article/Delete/5

        [HttpPost, ActionName("Delete")]
        public virtual ActionResult DeleteConfirmed(int id)
        {
            Article article = context.Articles.Single(x => x.ArticleId == id);
            context.Articles.Remove(article);
            context.SaveChanges();
            return RedirectToAction(MVC.Default.Article.UserArticles());
        }

        public virtual ActionResult UserArticles()
        {
            return View(ArticleService.GetUserArticles(WebSecurity.CurrentUserId));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}